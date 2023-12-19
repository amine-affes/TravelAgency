import Button from 'react-bootstrap/Button';

function DsButton(props: any) {

  const btnClassName = ['']

  if (props.className) {
    btnClassName.push(props.className)
  }
  return (
    <Button variant={props.variant} className={btnClassName.join(' ')} onClick={props.onclick}>{props.text}</Button>
  )
}

export default DsButton
