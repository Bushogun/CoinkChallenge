import { useRoutes, BrowserRouter } from 'react-router-dom'
import Home from '../pages/Home'
import UserList from '../pages/UserList'
import './App.css'

const AppRoutes = () => {
  let routes = useRoutes([
    { path: '/', element: <Home /> },
    { path: '/UserList', element: <UserList /> },
  ])
  return routes
}

function App() {

  return (
    <BrowserRouter>
      <AppRoutes />
    </BrowserRouter>
  )
}

export default App
