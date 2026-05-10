using Models;

namespace DamageConsoleApp
{
    internal class Program
    {
        private readonly static HttpClient _httpClient = new();
        static async Task Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Menu.DisplayMenu();
                    int option = InputValidation.ValidateMenuOptionInput(Console.ReadLine());
                    if (option != 0)
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Create a new Warrior");
                                break;
                            case 2:
                                Console.WriteLine("Spawn an existing Warrior");
                                break;
                            case 3:
                                Console.WriteLine("Damage a Warrior");
                                break;
                            case 4:
                                Console.WriteLine("Delete a Warrior");
                                break;
                            default:
                                isRunning = false;
                                break;
                        }
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
