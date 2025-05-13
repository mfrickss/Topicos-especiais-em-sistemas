import { useState } from 'react'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <h1>contagem do sexo</h1>
      </div>
    
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          sexo {count}
        </button>
      </div>
    </>
  )
}

export default App
