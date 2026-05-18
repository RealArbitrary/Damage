import { useState } from "react";

export function CreateWarrior() {
  const [warriorName, setWarriorName] = useState("");
  const [warriorHealth, setWarriorHealth] = useState(100);
  const [createdWarrior, setCreatedWarrior] = useState(null);

  return (
    <div>
      <h3>Create Warrior</h3>
      <div>
        <span className="label">Name:</span>
        <input
          type="text"
          value={warriorName}
          onChange={(e) => setWarriorName(e.target.value)}
        />
      </div>
      <div>
        <span className="label">Health:</span>
        <input
          type="number"
          value={warriorHealth}
          onChange={(e) => setWarriorHealth(Number(e.target.value))}
        />
      </div>
      <div>
        <CreateButton
          name={warriorName}
          health={warriorHealth}
          onWarriorCreated={setCreatedWarrior}
        />
      </div>
      {createdWarrior && (
        <p style={{ color: "green" }}>
          Warrior "{createdWarrior.name}" created with {createdWarrior.health}{" "}
          HP and a spawn ID of {createdWarrior.id}!
        </p>
      )}
    </div>
  );
}

function CreateButton({ name, health, onWarriorCreated }) {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const handleClick = async () => {
    setLoading(true);
    setError(null);
    try {
      const response = await fetch(
        `${import.meta.env.VITE_API_BASE_URL}/api/Warrior/add`,
        {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({ name, health }),
        },
      );
      if (!response.ok) {
        const message = await response.text();
        throw new Error(message);
      }
      const json = await response.json();
      onWarriorCreated?.(json);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div>
      <button onClick={handleClick} disabled={loading}>
        {loading ? "Creating..." : "Create!"}
      </button>
      {error && <p style={{ color: "red" }}>{error}</p>}
    </div>
  );
}
