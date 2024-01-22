import { Stack, TextField, TextFieldVariants } from "@mui/material";

interface IBasicField {
    variant?: TextFieldVariants | undefined
    label?: string,
    value: string,
    name:string,
    onChange: (e: any) => void
}

const InputField = ({ variant = "outlined", label = "Text",name = "", value, onChange }: IBasicField) => {
    return <>
        <TextField label={label} variant={variant} value={value} onChange={onChange} name={name} />
    </>;
}

export default InputField;

