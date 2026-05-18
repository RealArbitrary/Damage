import { CreateWarrior } from "./CreateWarrior";
import { DamageWarrior } from "./DamageWarrior";
import { DeleteWarrior } from "./DeleteWarrior";
import { SpawnWarrior } from "./SpawnWarrior";

function Warrior() {
  return (
    <div>
      <CreateWarrior />
      <SpawnWarrior />
      <DamageWarrior />
      <DeleteWarrior />
    </div>
  );
}

export default Warrior;
