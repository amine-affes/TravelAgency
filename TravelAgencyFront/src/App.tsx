import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'
import DsForm from './components/DsForm';
import { useState } from 'react'
import { gql, useQuery } from '@apollo/client';

const App = () => {

  const [name, setName] = useState<string>("")
  const [familyName, setFamilyName] = useState<string>("")
  const [clientInfo, setClientInfo] = useState<any>(null)
  const [error, setError] = useState<boolean>(false)

  const GET_CLIENT = gql`
  query {
    dossier(name:AA, familyName:AA) {
      id,
      client{name, familyName},
      product{name, location}
    }
  }
`;

  const { loading, error: queryError, data } = useQuery(GET_CLIENT);
  const getClientInfo = () => {

    if (error) {
      setError(true)
    } else {
      console.log("data: ", data);

      setClientInfo(data)
    }
  }

  return (
    <>
      <DsForm
        className='form-client'
        onChangeName={(e: React.ChangeEvent<HTMLInputElement>) => setName(e?.target?.value)}
        onChangeFamilyName={(e: React.ChangeEvent<HTMLInputElement>) => setFamilyName(e?.target?.value)}
        nameValue={name}
        familyNameValue={familyName}
        onclick={() => getClientInfo()}
      />
      {error && <p>User not Found ...</p>}
      {clientInfo !== null && <>
        <p>User name :{clientInfo?.name}</p>
        <p>User family name :{clientInfo?.familyName}</p>
        <p>User arrival date :{clientInfo?.arrivalDate}</p>
        <p>User flight location :{clientInfo?.location}</p>
      </>}
    </>
  )
}

export default App
