namespace DamageConsoleApp
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Warrior Damage Console App!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Create a Warrior");
            Console.WriteLine("2. Spawn a Warrior");
            Console.WriteLine("3. Damage a Warrior");
            Console.WriteLine("4. Delete a Warrior");
            Console.WriteLine("99. Exit");
        }
    }
}
