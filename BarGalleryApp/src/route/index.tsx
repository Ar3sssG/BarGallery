import {
    createBrowserRouter,
} from "react-router-dom";

import Home from "../pages/Home";
//import Hi from "../pages/Hi";

const router = createBrowserRouter([
    {
        path: "/",
        element: <Home />,
    },
    //{
    //    path: "/hi",
    //    element: <Hi />
    //},
]);

export default router;