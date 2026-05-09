using Models;

namespace DamageConsoleApp
{
    internal class Program
    {
        private readonly static HttpClient _httpClient = new();
        static async Task Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                try
                {
                    Console.WriteLine("Provide the ID of the warrior you want: ");
                    int warriorId = InputValidation.ValidateInput(Console.ReadLine());

                    if (warriorId != 0)
                    {
                        var spawnWarrior = await WarriorLogic.SpawnWarrior(warriorId, _httpClient);
                        Warrior warrior = spawnWarrior;
                        Console.WriteLine(warrior.Health);
                        Console.WriteLine(warrior.Name);
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
