import { Stack, TextField, TextFieldVariants } from "@mui/material";
import { ChangeEventHandler } from "react";

interface IBasicField {
    variant?: TextFieldVariants | undefined
    label?: string,
    value: string,
    name:string,
    type?:string,
    onChange: ChangeEventHandler<HTMLInputElement>
}

const InputField = ({ variant = "outlined", label = "Text",name = "", type = "text",value, onChange }: IBasicField) => {
    return <>
        <TextField label={label} variant={variant} value={value} onChange={onChange} name={name} type={type}/>
    </>;
}

export default InputField;

