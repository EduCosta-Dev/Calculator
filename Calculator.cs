using System;
using NumberValidator;

namespace _Calculator
{
    public class Calculator
    {
        private readonly RunValidator Validator = new RunValidator();
        public void RunCalculator()
        {
            while (true)
            {
                Console.Clear();

                float firstNumber = Validator.IsValidNumber();
                float secondNumber = Validator.IsValidNumber();

                string operatorInput = Validator.IsValidOperator();

                float result = 0;
                bool validOperation = true;

                switch (operatorInput)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "*":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Division by zero. Please enter a new second number.");
                            secondNumber = Validator.IsValidNumber();
                            result = firstNumber / secondNumber;
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown operator.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"\nResult: {firstNumber}{operatorInput}{secondNumber} = {result}");
                }

                Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                string response = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (response != "y")
                {
                    Console.WriteLine("Exiting calculator...");
                    break;
                }
            }
        }
    }
}