import Form from 'react-bootstrap/Form';
import DsButton from '../DesignSystem/DsButton';
import DsFormControl from '../DesignSystem/DsFormControl';

function DsForm(props:any) {
  return (
    <>
      <Form className={props.className}>
        <DsFormControl
          groupClassName="mb-3"
          controlId="ControlInput1"
          label="Name:"
          controlType="text"
          placeholder="Provide your name"
          onChange={props.onChangeName}
          value={props.nameValue}
        />
        <DsFormControl
          groupClassName="mb-3"
          controlId="ControlInput2"
          label="Family name:"
          controlType="text"
          placeholder="Provide your family name"
          onChange={props.onChangeFamilyName}
          value={props.familyNameValue}
        />
        <DsButton variant="primary" text="Submit" onclick={props.onclick} />
      </Form>
    </>
  )
}

export default DsForm
