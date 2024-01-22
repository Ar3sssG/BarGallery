import { Button, Stack } from "@mui/material";
interface IBasicButton {
    variant?: "contained" | "text" | "outlined",
    title?: string,
    fullWidth?: boolean
}

const BasicButton = ({ variant = "contained", title = "Text", fullWidth = false }: IBasicButton) => {
    return (
        <Button sx={{ textTransform: "none" }} fullWidth={fullWidth} variant={variant}>{title}</Button>
    );
}

export default BasicButton;