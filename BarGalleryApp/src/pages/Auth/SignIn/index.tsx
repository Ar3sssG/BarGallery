import { Box, Stack } from "@mui/material";
import BasicButton from "../../../shared/UI/Button";
import InputField from "../../../shared/UI/Input";
import CustomCheckBox from "../../../shared/UI/Checkbox";
import { ChangeEvent, useState } from "react";

const url = "https://example.com/answer";

const Signin = () => {
    const [inputValue, setInputValue] = useState({
        username: "",
        password: "",
    })
    const [checkboxValue, setCheckboxValue] = useState(
        false

    )

    const onCheckboxChange = (e: ChangeEvent<HTMLInputElement>) => {
        setCheckboxValue(e.target.checked)

    }
    const onInputChange = (e: ChangeEvent<HTMLInputElement>) => {
        setInputValue({
            ...inputValue,
            [e.target.name]: e.target.value
        })
    }
    const handleFetchData = async() => {
        const response = await fetch(url,{
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({...inputValue,checkboxValue})
        })
        const res = response.json()
        console.log(res)
    }

    const onClick =  (e: MouseEvent) => {
        handleFetchData()
    }

    return (
        <>
            <Box sx={{ height: "50vh", display: "flex", justifyContent: "center", flexDirection: "column", alignItems: "center" }}>
                <h1>BarGallery Admin</h1>
                <h2>Sign in</h2>
                <Stack spacing={2} sx={{ width: "20vw" }}>
                    <InputField label="Username" variant="filled" value={inputValue.username} onChange={onInputChange} name="username" />
                    <InputField label="Password" variant="filled" value={inputValue.password} onChange={onInputChange} name="password" type="password" />
                    <CustomCheckBox label="Remember me" value={checkboxValue} onChange={onCheckboxChange} />
                    <BasicButton title="Sign in" fullWidth onClick={onClick} />
                </Stack>
                <p>Copyright © BarGallery 2024.</p>
                <p>Hello world!</p>
            </Box>
        </>
    );
}

export default Signin;