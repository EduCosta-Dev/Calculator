namespace NumberValidator
{
    public class RunValidator
    {
        public float HandleNumberValidator()
        {
            float numberValidated;
            Console.WriteLine("Enter a number:");

            while (!float.TryParse(Console.ReadLine(), out numberValidated))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            return numberValidated;
        }

        public string HandleOperatorValidator()
        {
            string[] validOperators = { "+", "-", "*", "/", "sum", "subtraction", "multiplication", "division" };

            Console.WriteLine("Enter an operator (+, -, *, /, sum, subtraction, multiplication, division):");

            while (true)
            {
                string operatorInput = Console.ReadLine() ?? "";

                foreach (var op in validOperators)
                {
                    if (op == operatorInput)
                    {
                        return operatorInput;
                    }
                }

                Console.WriteLine("Invalid operator. Please enter again:");
            }
        }
    }
}