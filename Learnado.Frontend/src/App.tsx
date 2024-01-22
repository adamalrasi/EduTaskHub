import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <a href="#" target="_blank">
          <img src="/Learnado_Logo.png" className="logo" alt="Vite logo" />
        </a>
      </div>
      <h1 className='text-3xl border p-5'>Future of Learning, Designed for Today</h1>
      <div className="card">
        <p>
          Classroom grading & assignment sharing made easy.
        </p>
        <p>
          Available in all web browsers and mobiles.
        </p>
      </div>
     <div >
      <button className='border rounded-xl p-3 m-1'>Sign Up</button>
      <button className='m-1'>{"Demo Video ->"}</button>
     </div>
    </>
  )
}

export default App
