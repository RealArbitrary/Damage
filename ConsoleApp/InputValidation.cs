namespace DamageConsoleApp
{
    internal static class InputValidation
    {
        public static int ValidateInput(string? input)
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
    }
}
