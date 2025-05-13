import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import Xablau from './components/xablau'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <App />
    <Xablau titulo="Coxinha" />
  </StrictMode>,
)
