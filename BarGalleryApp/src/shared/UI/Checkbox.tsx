import { Checkbox, FormControlLabel } from "@mui/material"

interface IBasicCheckbox {
    defaultChecked?: boolean
    label?: string,
    value: boolean,
    onChange: (e:any) => void
}

const CustomCheckBox = ({ defaultChecked = false, label = "Text" , value, onChange}: IBasicCheckbox) => {
    return <>
        <FormControlLabel control={<Checkbox defaultChecked={defaultChecked} value={value} onChange={onChange}/>} label={label} />
    </>
}

export default CustomCheckBox;