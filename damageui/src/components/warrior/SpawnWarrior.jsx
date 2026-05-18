import { useState } from "react";

export function SpawnWarrior() {
  const [warriorId, setWarriorId] = useState();
  const [warrior, setWarrior] = useState(null);

  return (
    <div>
      <h3>Spawn Warrior</h3>
      <div>
        <span className="label">WarriorId: </span>
        <input
          type="number"
          id="warriorId"
          onChange={(e) => setWarriorId(parseInt(e.target.value))}
        />
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
        <SpawnButton id={warriorId} onWarriorLoaded={setWarrior} />
      </div>
      {warrior && (
        <p style={{ color: "green" }}>
          Warrior "{warrior.name}" spawned with {warrior.health} HP and ID{" "}
          {warrior.id}!
        </p>
      )}
    </div>
  );
}
function SpawnButton({ id, onWarriorLoaded }) {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const handleClick = async () => {
    setLoading(true);
    setError(null);
    try {
      const response = await fetch(
        `${import.meta.env.VITE_API_BASE_URL}/api/Warrior/${id}`,
      );
      if (!response.ok) {
        const message = await response.text();
        throw new Error(message);
      }
      const json = await response.json();
      onWarriorLoaded?.(json);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div>
      <button onClick={handleClick} disabled={loading}>
        {loading ? "Loading..." : "Spawn!"}
      </button>
      {error && <p style={{ color: "red" }}>{error}</p>}
    </div>
  );
}
