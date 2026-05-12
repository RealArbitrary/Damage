import './App.css'
import swords from './assets/swords.svg'
import { CreateWarrior, DamageWarrior, DeleteWarrior, SpawnWarrior } from './components/warrior/WarriorMaster';

function App() {
    return (
        <div>
            <img src={swords} id="swords" />
            <section id="warriorActions">
                <div>
                    <SpawnWarrior />
                </div>

                <div>
                    <CreateWarrior />
                </div>

                <div>
                    <DamageWarrior />
                </div>

                <div>
                    <DeleteWarrior />
                </div>
            </section>
        </div>
    )
}

export default App
