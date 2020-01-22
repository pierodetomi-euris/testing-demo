using System;

namespace TestingDemo
{
    public class Calculator
    {
        public decimal Add(decimal operand1, decimal operand2)
        {
            return (operand1 + operand2);
        }

        public decimal Subtract(decimal operand1, decimal operand2)
        {
            return (operand1 - operand2);
        }

        public decimal Multiply(decimal operand1, decimal operand2)
        {
            return (operand1 * operand2);
        }

        public decimal Divide(decimal operand1, decimal operand2)
        {
            if (operand2 == 0)
                throw new ArgumentException("Il dividendo non può essere pari a zero", "d2");

            return (operand1 / operand2);
        }
    }
}