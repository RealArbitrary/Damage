import { useState } from "react";

export default function DamageButton({ id, onWarriorLoaded }) {
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(null);


    const handleClick = async () => {
        setLoading(true);
        setError(null);
        try {
            const response = await fetch(`${import.meta.env.VITE_API_BASE_URL}/api/Warrior/${id}`);
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