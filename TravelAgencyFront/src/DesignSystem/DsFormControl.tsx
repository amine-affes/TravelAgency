import Form from 'react-bootstrap/Form';

function DsFormControl(props:any) {
    return (
        <Form.Group className={props.groupClassName} controlId={props.controlId}>
            <Form.Label>{props.label}</Form.Label>
            <Form.Control type={props.controlType} placeholder={props.placeholder} onChange={props.onChange} value={props.value} />
        </Form.Group>
    )
}

export default DsFormControl