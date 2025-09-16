namespace DependancyInjection2
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing Wood");
        }
    }

    // Dependancy Example

    //public class Builder
    //{
    //    private Hammer _hammer; //Field of class Hammer
    //    private Saw _saw;

    //    public Builder()
    //    {
    //        _hammer = new Hammer(); //Builder is responsible for creating its dependancy
    //        _saw = new Saw();
    //    }

    //    public void BuildHouse()
    //    {
    //        _hammer.Use();
    //        _saw.Use();
    //        Console.WriteLine("House Built");
    //    }
    //}

    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        // Setter Dependancy Injection
        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House Built");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer(); // Create the dependencies
            Saw saw = new Saw();
            Builder builder = new Builder();
            // Parsing the property into the BuildHouse method
            builder.Hammer = hammer; // Inject dependacies via Setters
            builder.Saw = saw; // Inject dependacies via Setters

            builder.BuildHouse();

            Console.ReadKey();
        }
    }
}
