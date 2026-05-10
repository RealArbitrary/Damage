namespace DamageConsoleApp
{
    internal static class InputValidation
    {
        public static int ValidateWarriorIdInput(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input: Input cannot be empty.");
                return 0;
            }

            if (!int.TryParse(input, out int warriorId))
            {
                Console.WriteLine($"Invalid input: {input}. Enter a valid number from 1 - 30");
                return 0;
            }

            if (warriorId < 1 || warriorId > 30)
            {
                Console.WriteLine("Invalid input: Warrior ID must be between 1 and 30.");
                return 0;
            }

            return warriorId;
        }
        public static int ValidateDamageInput(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input: Input cannot be empty.");
                return 0;
            }
            if (!int.TryParse(input, out int damage))
            {
                Console.WriteLine($"Invalid input: {input}. Enter a valid number from 1 - 100");
                return 0;
            }
            if (damage < 1 || damage > 100)
            {
                Console.WriteLine("Invalid input: Damage must be between 1 and 100.");
                return 0;
            }
            return damage;
        }
        public static int ValidateMenuOptionInput(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input: Input cannot be empty.");
                return 0;
            }
            if (!int.TryParse(input, out int option))
            {
                Console.WriteLine($"Invalid input: {input}. Enter a valid number from the menu options");
                return 0;
            }
            if (option == 99)
            {
                Console.WriteLine("Exiting appliction...");
                return option;
            }
            if (option < 1 || option > 3)
            {
                Console.WriteLine("Invalid input: Option must be one of the menu options");
                return 0;
            }
            return option;
        }
    }
}
