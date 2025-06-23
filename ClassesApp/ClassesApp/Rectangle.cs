using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
        // In C#, const annd readonly are two keywords used to define non-modifiable fields, but they differ in terms of when they are initialized and their usage contexts.
        // Understanding the differences between these two can help in deciding which one to use based on specific requirements.

        // declaration of the field
        public const int NumberOfCorners = 4; // Has to be run at compile time(needs to be hard coded)
        // Constant in every instance^^

        // declaration of the field
        public readonly string Colour; // Can be run after compile time(It can use methods for the value)
        // Can be different with each instance

        public Rectangle(string colour)
        {
            Colour = colour;
        }

        // Method to display the details of the rectangle
        public void DisplayDetails()
        {
            Console.WriteLine($"Colour: {Colour}, Width: {Width}, Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }

        public double Width {  get; set; }
        public double Height { get; set; }

        // Computed property
        // Read Only Property
        public double Area
        {
            get { return Width * Height; }
        }
    }
}
