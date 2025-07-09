using System;
using NumberValidator;

namespace _Calculator
{
    public class Calculator
    {
        private RunValidator validator = new RunValidator();

        public void RunCalculator()
        {
            while (true)
            {
                // Coleta dos dados em cada iteração
                float firstNumber = validator.HandleNumberValidator();
                float secondNumber = validator.HandleNumberValidator();
                string operatorInput = validator.HandleOperatorValidator();

                float result;

                switch (operatorInput)
                {
                    case "+":
                    case "sum":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                    case "subtraction":
                        result = firstNumber - secondNumber;
                        break;

                    case "*":
                    case "multiplication":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                    case "division":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Division by zero.");
                            continue; // volta para o início do loop
                        }
                        result = firstNumber / secondNumber;
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
                string response = Console.ReadLine() ?? "";

                if (response.ToLower() != "y")
                {
                    Console.WriteLine("Exiting calculator...");
                    break;
                }

                Console.Clear();
            }
        }
    }
}