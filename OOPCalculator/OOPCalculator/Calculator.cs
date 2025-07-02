using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    internal class Calculator
    {
        public int inputA {  get; set; }
        public int inputB { get; set; }

        public int Add()
        {
            return inputA + inputB;
        }
        public int Subtract()
        {
            return inputA - inputB;
        }
        public int Multiply()
        {
            return inputA * inputB;
        }
        public double Divide()
        {
            if (inputB == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN; // Return "Not a Number" to indicate an error.
            }
            return (double)inputA / inputB;
        }
    }
}
