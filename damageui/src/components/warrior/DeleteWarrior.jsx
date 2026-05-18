export function DeleteWarrior() {
  return (
    <div>
      <h3>Delete Warrior</h3>
      <div>
        <span className="label">WarriorId: </span>
        <input type="number" />
      </div>
      <div>
        <span className="label">Result: </span>
        <input type="text" readOnly defaultValue="Deleted Warrior Name" />
      </div>
      <div>
        <button>Delete!</button>
      </div>
    </div>
  );
}
