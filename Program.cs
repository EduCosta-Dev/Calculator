using System;
using _Calculator;
using NumberValidator;

class Program
{
    static void Main(string[] args)
    {
        RunValidator validator = new RunValidator();

        while (true)
        {
            float firstNumber = validator.HandleNumberValidator();
            float secondNumber = validator.HandleNumberValidator();
            string operatorInput = validator.HandleOperatorValidator();

            Calculator calc = new Calculator(firstNumber, secondNumber, operatorInput);

            float result = calc.HandleCalculator();

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("\nDo you want to perform another calculation? (Y/N)");
            string response = Console.ReadLine() ?? "y";
            System.Console.WriteLine(response);

            if (response != "y" && response != "Y")
            {
                Console.WriteLine("Exiting calculator...");
                break;
            }
            Console.Clear();
        }
    }
}