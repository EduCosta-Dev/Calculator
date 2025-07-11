using System.Runtime.CompilerServices;
using Menu;

namespace NumberValidator
{
    public class RunValidator
    {
        private readonly ShowMenu Menu = new ShowMenu();
        private static readonly string[] ValidOperators = new string[]
        {
            "1", "2", "3", "4",
            "sum", "subtraction", "multiplication", "division",
            "+", "-", "*", "/"
        };
        public float IsValidNumber()
        {
            float numberValidated;
            Console.WriteLine("Enter a number:");

            while (!float.TryParse(Console.ReadLine(), out numberValidated))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            return numberValidated;
        }

        public string IsValidOperator()
        {
            Menu.Show();

            while (true)
            {
                Console.Write("Select operator: ");
                string input = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (ValidOperators.Contains(input))
                {
                    return input switch
                    {
                        "1" or "sum" or "+" => "+",
                        "2" or "subtraction" or "-" => "-",
                        "3" or "multiplication" or "*" => "*",
                        "4" or "division" or "/" => "/",
                        _ => input
                    };
                }

                Console.WriteLine("Invalid operator. Try again.");
            }
        }

    }
}