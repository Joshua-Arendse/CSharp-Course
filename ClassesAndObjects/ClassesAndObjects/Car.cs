using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        //Member variables
        private string _name; //private field typically used for storing data.
        private int _hp;
        private string _colour;

        //Constructor
        public Car(string name, int hp = 0, string colour = "black") {
            _name = name;
            Console.WriteLine(name +" was created!");
            _hp = hp;
            _colour = colour;
        }
        //Member Method
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }
        //Member Method
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }
        public void Details()
        {
            Console.WriteLine("The " + _colour + " car " + _name + " has " + _hp + " horsepower");
        }
    }
}
