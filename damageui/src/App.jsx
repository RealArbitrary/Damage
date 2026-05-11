import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'

function App() {
    const [count, setCount] = useState(0)

    return (
        <>
            <section id="center">
                <div className="hero">
                    <img src={heroImg} className="base" width="170" height="179" alt="" />
                    <img src={reactLogo} className="framework" alt="React logo" />
                    <img src={viteLogo} className="vite" alt="Vite logo" />
                </div>
                <div>
                    <h1>Get started</h1>
                    <p>
                        Edit <code>src/App.jsx</code> and save to test <code>HMR</code>
                    </p>
                </div>
                <button
                    type="button"
                    className="counter"
                    onClick={() => setCount((count) => count + 1)}
                >
                    Count is {count}
                </button>

            </section>

            <div className="ticks"></div>

            <section id="next-steps">
                <div id="docs">
                    <h3>Spawn a Warrior</h3>
                    <div>
                        <span className="label">WarriorId: </span>
                        <input type="number" />

                    </div>
                    <div>
                        <span className="label">Name: </span>
                        <input type="text" readOnly />
                    </div>
                    <div>
                        <span className="label">Health: </span>
                        <input type="number" readOnly />

                    </div>
                    <div>
                        <button>
                            Spawn!
                        </button>
                    </div>
                </div>
                <div id="docs">
                    <h3>Create a warrior</h3>
                    <div>
                        <span className="label">Name: </span>
                        <input type="text" />

                    </div>
                    <div>
                        <span className="label">Health: </span>
                        <input type="number" defaultValue="100" />
                    </div>
                    <div>
                        <button>
                            Create!
                        </button>
                    </div>
                </div>

                <div id="docs">
                    <h3>Do damage</h3>
                    <div>
                        <span className="label">WarriorId: </span>
                        <input type="text" />

                    </div>
                    <div>
                        <span className="label">Damage: </span>
                        <input type="number" />
                    </div>
                    <div>
                        <button>
                            Damage!
                        </button>
                    </div>
                </div>



                <div id="docs">
                    <h3>Delete a warrior</h3>
                    <div>
                        <span className="label">WarriorId: </span>
                        <input type="number" />
                    </div>
                    <div>
                        <span className="label">Result: </span>
                        <input type="text" readOnly defaultValue="Result" />
                    </div>
                    <div>
                        <button>
                            Delete!
                        </button>
                    </div>
                </div>
            </section>
            <div className="ticks"></div>
            <section id="spacer"></section>
        </>
    )
}

export default App
