namespace Structs
{
    public struct Point
    {
        //It's common practice to make structs immutable by declaring all fields as readonly and providing only the get accessors for properties.

        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2 = new Point(20, 30);
            p2.Display();

            //This is to show that p3 just takes the values from p1 but does not become p1 (it can override the value)
            Point p3 = p1;
            p1.Display();
            p3.Display();

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distnace between points: {distance:F2}");//F2 gives us 2 decimal points


            Console.ReadKey();
        }
    }
}
