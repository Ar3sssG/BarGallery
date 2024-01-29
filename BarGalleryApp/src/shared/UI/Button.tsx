import { Button, Stack } from "@mui/material";
import { MouseEventHandler } from "react";

interface IBasicButton {
    variant?: "contained" | "text" | "outlined",
    title?: string,
    fullWidth?: boolean,
    onClick: MouseEventHandler<HTMLButtonElement>
}

const BasicButton = ({ variant = "contained", title = "Text", fullWidth = false, onClick }: IBasicButton) => {
    return (
        <Button
            sx={{ textTransform: "none" }}
            onClick={onClick}
            fullWidth={fullWidth}
            variant={variant}>
            {title}
        </Button>
    );
}

export default BasicButton;