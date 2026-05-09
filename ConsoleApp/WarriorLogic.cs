using Models;
using System.Net.Http.Json;
namespace DamageConsoleApp
{
    internal class WarriorLogic
    {
        public static async Task<Warrior> SpawnWarrior(int warriorId, HttpClient client)
        {
            using HttpResponseMessage response = await client.GetAsync($"https://localhost:7206/{warriorId}");

            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException($"Failed: {errorMessage}");
            }

            Warrior? w = await response.Content.ReadFromJsonAsync<Warrior>();

            return w ?? throw new InvalidOperationException("Failed to deserialize warrior.");
        }
    }
}
