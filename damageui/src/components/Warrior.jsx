export default function Warrior() {
  return (
    <div>
      <h3>Warrior</h3>
      <div>
        <span className="label">WarriorId: </span>
        <input type="number" id="warriorId" />
      </div>
      <div>
        <span className="label">Name: </span>
        <input type="text" readOnly />
      </div>
      <div>
        <span className="label">Health: </span>
        <input type="number" readOnly />
      </div>
    </div>
  );
}
