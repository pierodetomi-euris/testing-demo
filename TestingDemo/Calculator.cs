using System;

namespace TestingDemo
{
    public class Calculator
    {
        public decimal Add(decimal d1, decimal d2)
        {
            return (d1 + d2);
        }

        public decimal Subtract(decimal d1, decimal d2)
        {
            return (d1 - d2);
        }

        public decimal Multiply(decimal d1, decimal d2)
        {
            return (d1 * d2);
        }

        public decimal Divide(decimal d1, decimal d2)
        {
            if (d2 == 0)
                throw new ArgumentException("Il dividendo non può essere pari a zero", "d2");

            return (d1 / d2);
        }
    }
}