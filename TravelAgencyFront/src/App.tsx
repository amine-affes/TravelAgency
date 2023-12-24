import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'
import DsForm from './components/DsForm';
import { useState } from 'react'

function App() {

  const [name, setName] = useState<string>("")
  const [familyName, setFamilyName] = useState<string>("")
  const [clientInfo, setClientInfo] = useState<any>(null)
  const [error, setError] = useState<boolean>(false)

  const getClientInfo = () => {
    fetch(`https://localhost:7165/GraphQL?name=${name}&familyName=${familyName}`, {
      method: "GET",
    })
      .then((response) => response.json())
      .then((responseJson) => {
        if (responseJson.status === 200) {
          setClientInfo(responseJson?.data)
        } else {
          setError(true)
        }
      })
      .catch((error) => {
        console.error(error);
      });
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
