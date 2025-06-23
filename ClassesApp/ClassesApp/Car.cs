using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    // It is Internal, which means it can only be accessed from within the assembly
    internal class Car
    {
        // Member Variable
        // Private hides the variable from other classes
        // Backing Field of the Model property
        private string _model = "";
        private string _brand = "";

        private bool _isLuxury;

        // Property
        // With lambda expression (=>)
        public string Model { get => _model; set => _model = value; }
        public string Brand { 
            
            get
            {
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            } 
            
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You have entered nothing");
                    _brand = "DefaultValue";
                }else
                {
                    _brand = value;
                }
            } 
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Custom Constructor
        public Car(string model,string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} has been created!");
            IsLuxury = isLuxury;
        }
        // Methods in Classes
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }

    }
}
