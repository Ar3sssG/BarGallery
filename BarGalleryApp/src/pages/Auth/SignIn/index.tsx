import { Box, Stack } from "@mui/material";
import BasicButton from "../../../shared/UI/Button";
import InputField from "../../../shared/UI/Input";
import CustomCheckBox from "../../../shared/UI/Checkbox";
import { useState } from "react";

const Signin = () => {
    const [value, setValue] = useState({
        username:"",
        password:"",
        remember:false
    });

    const onChange = (e: any) => {
        setValue({
            ...value,
            [e.target.name]:e.target.value
        })
        console.log(e.target.value)
    }
    return (
        <>
            <Box sx={{ height: "50vh", display: "flex", justifyContent: "center", flexDirection: "column", alignItems: "center" }}>
                <h1>SIGN IN</h1>
                <Stack spacing={2}>
                    <InputField label="Username" variant="standard" value={value.username} onChange={onChange} name="username"/>
                    <InputField label="Password" variant="standard" value={value.password} onChange={onChange} name="password" />
                    <CustomCheckBox label="Remember me" value={value.remember} onChange={onChange}/>
                    <BasicButton title="Sign in" fullWidth />
                </Stack>
            </Box>

        </>
    );
}

export default Signin;