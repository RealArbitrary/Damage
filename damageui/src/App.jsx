import swords from './assets/swords.svg'
import './App.css'
import DamageButton from './components/DamageButton'
import { useState } from 'react';

function App() {
    const [warriorId, setWarriorId] = useState();
    const [warrior, setWarrior] = useState(null);

    return (
        <div>
            <img src={swords} id="swords" />
            <section id="warriorActions">
                <div id="docs">
                    <h3>Spawn a Warrior</h3>
                    <div>
                        <span className="label">WarriorId: </span>
                        <input type="number" id="warriorId" onChange={e => setWarriorId(parseInt(e.target.value))} />

                    </div>
                    <div>
                        <span className="label">Name: </span>
                        <input type="text" readOnly value={warrior?.name ?? ""} />
                    </div>
                    <div>
                        <span className="label">Health: </span>
                        <input type="number" readOnly value={warrior?.health ?? ""} />

                    </div>
                    <div>
                        <DamageButton id={warriorId} onWarriorLoaded={setWarrior} />
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
        </div>
    )
}

export default App
