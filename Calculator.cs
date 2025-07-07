using System;

namespace _Calculator
{
    public class Calculator
    {
        private float FirstNumber { get; set; }
        private float SecondNumber { get; set; }
        private string Operator { get; set; }

        public Calculator(float firstNumber, float secondNumber, string operatorInput)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Operator = operatorInput;
        }

        public float HandleCalculator()
        {
            switch (Operator)
            {
                case "+":
                case "sum":
                    return FirstNumber + SecondNumber;

                case "-":
                case "subtraction":
                    return FirstNumber - SecondNumber;

                case "*":
                case "multiplication":
                    return FirstNumber * SecondNumber;

                case "/":
                case "division":
                    if (SecondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        return 0;
                    }
                    return FirstNumber / SecondNumber;

                default:
                    Console.WriteLine("Invalid operation.");
                    return 0;
            }
        }
    }
}