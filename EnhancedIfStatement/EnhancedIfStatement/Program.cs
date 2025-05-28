using System;

namespace EnhancedIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            condition ? first_expression : second_expression;
            condition has to be either true or false
            The conditional operator is right - associate.
            The expression a ? b : c? d : e
            Is evaluated as a ? b : (c? d : e),
            not as (a ? b : c) ? d : e.
            The conditional operator cannot be overloaded.
             */

            //in Celcius
            int temp = -5;
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temp += 30;

            //in short
            stateOfMatter = temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //Challenge - add the gas state of matter to the options
            temp += 100; 
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            Console.ReadKey();
        }
    }
}