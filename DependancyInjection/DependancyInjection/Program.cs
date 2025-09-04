namespace DependancyInjection
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
        private Hammer _hammer; //Field of class Hammer
        private Saw _saw;

        // Contructor Dependancy Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House Built");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();
            
            Console.ReadKey();
        }
    }
}
