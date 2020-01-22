using System;

namespace TestingDemo
{
    class Program
    {
        private static Calculator Calculator;

        static void Main(string[] args)
        {
            Calculator = new Calculator { };

            bool wantsToExit = false;

            while(!wantsToExit)
            {
                ConsoleKey operation = ShowMenu();

                decimal operand1 = 0;
                decimal operand2 = 0;
                decimal result = 0;

                switch (operation)
                {
                    case ConsoleKey.A:
                        operand1 = RequestOperand(1);
                        operand2 = RequestOperand(2);
                        result = Calculator.Add(operand1, operand2);
                        break;

                    case ConsoleKey.S:
                        operand1 = RequestOperand(1);
                        operand2 = RequestOperand(2);
                        result = Calculator.Subtract(operand1, operand2);
                        break;

                    case ConsoleKey.M:
                        operand1 = RequestOperand(1);
                        operand2 = RequestOperand(2);
                        result = Calculator.Multiply(operand1, operand2);
                        break;

                    case ConsoleKey.D:
                        operand1 = RequestOperand(1);
                        operand2 = RequestOperand(2);
                        result = Calculator.Divide(operand1, operand2);
                        break;

                    case ConsoleKey.Escape:
                        wantsToExit = true;
                        continue;

                    default:
                        Console.WriteLine("Operation not supported!");
                        Console.WriteLine(string.Empty);
                        Console.WriteLine("Press any key to continue ...");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine(string.Empty);
                Console.WriteLine($"The result is: {result}");
                Console.WriteLine(string.Empty);
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
            }
        }

        private static decimal RequestOperand(int operandNumber)
        {
            Console.WriteLine($"Operand {operandNumber}: ");
            string op = Console.ReadLine();

            decimal.TryParse(op, out decimal operand);

            return operand;
        }

        private static ConsoleKey ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("Choose an operation:");

            Console.WriteLine("[A] Add");
            Console.WriteLine("[S] Subtract");
            Console.WriteLine("[M] Multiply");
            Console.WriteLine("[D] Divide");
            Console.WriteLine("----------------");
            Console.WriteLine("[ESC] Quit");

            ConsoleKey key = Console.ReadKey().Key;

            Console.Clear();

            return key;
        }
    }
}