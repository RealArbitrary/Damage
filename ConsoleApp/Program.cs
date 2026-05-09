using Models;

namespace DamageConsoleApp
{
    internal class Program
    {
        private readonly static HttpClient _httpClient = new();
        static async Task Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Provide the ID of the warrior you want: ");
            int warriorId = InputValidation.ValidateWarriorIdInput(Console.ReadLine());
            while (run)
            {
                try
                {
                    if (warriorId != 0)
                    {
                        var spawnWarrior = await WarriorLogic.SpawnWarrior(warriorId, _httpClient);
                        Warrior warrior = spawnWarrior;
                        Console.WriteLine($"Warrior spawned!");
                        Console.WriteLine($"{warrior.Name} has {warrior.Health} health");
                        Console.WriteLine($"Do some damage to {warrior.Name}!: ");
                    }
                    Console.WriteLine("Minimum damage: 1 and Maximum damage: 100");
                    int damage = InputValidation.ValidateDamageInput(Console.ReadLine());
                    if (damage != 0)
                    {
                        var damagedWarrior = await WarriorLogic.DamageWarrior(warriorId, damage, _httpClient);
                        Console.WriteLine($"{damage} Damage done!");
                        Console.WriteLine($"New Health: {damagedWarrior.Health}");
                        Console.ReadLine();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
