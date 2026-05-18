import "./App.css";
import swords from "./assets/swords.svg";
import Warrior from "./components/warrior/Warrior";

function App() {
  return (
    <div>
      <img src={swords} id="swords" />
      <section id="warriorActions">
        <div>
          <Warrior actions={["Create", "Read", "Update", "Delete"]} />
        </div>
      </section>
    </div>
  );
}

export default App;
