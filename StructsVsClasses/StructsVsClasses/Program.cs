using System.ComponentModel.Design;

namespace StructsVsClasses
{
    // Value type vs Reference type
    //Struct is a Value Type
    //while Class is a Reference Type
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: {X},{Y}");
        }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: {X},{Y}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2 = p1; //p2 is a copy of p1
            p2.Display();
            p2.X = 25; // Changes p2, p1 remains unchanged
            Console.WriteLine("After changing p2.X to 25");
            p1.Display();
            p2.Display();

            Console.WriteLine("NOW COME THE CLASS OBJECTS");
            PointClass pC1 = new PointClass(1,2);
            PointClass pC2 = pC1; // pC2 is a reference to the same object as pC1
            pC1.Display();
            pC2.Display();

            pC2.X = 3; // Changes pC1.X as well, since pC1 and pC2 reference the same object
            Console.WriteLine("After changing pC2.X to 3");
            pC1.Display();
            pC2.Display();

            bool isEqual = pC1.Equals(pC2);
            Console.WriteLine("is it equal?: " + isEqual);

            Console.ReadKey();
        }
    }
}