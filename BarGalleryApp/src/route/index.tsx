import {
    Navigate,
    createBrowserRouter,
} from "react-router-dom";

import Home from "../pages/Home";
import Signin from "../pages/Auth/SignIn";

const router = createBrowserRouter([
    {
        path: "/home",
        element: <Home />,
    },
    {
        path: "/sign-in",
        element: <Signin />
    },
    {
        path: "*",
        element: <Navigate to={"/sign-in" } />
    },
]);

export default router;