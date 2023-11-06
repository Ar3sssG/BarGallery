import { Button, Stack } from "@mui/material";
interface IBasicButton {
    variant?: "contained" | "text" | "outlined",
    title?: string
}

const BasicButton = ({ variant = "contained", title = "Text" }: IBasicButton) => {
    return (
        <Stack spacing={2} direction="row">
            <Button sx={{ textTransform: "none" }} variant={variant}>{title}</Button>
        </Stack>
    );
}

export default BasicButton;