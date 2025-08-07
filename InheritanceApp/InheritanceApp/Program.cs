namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // Base CLass (Parent Class or Superclass): The class whose members are inherited
    class Animal
    {
        public void eat()
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.eat();

            Console.WriteLine("Eating...");
        }
    }

    // Drerived Class (Child or Subclass):
    // The class that inherits the members of the base class.
    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    class Cat: Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing...");
        }
    }



    // A breed of dog
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts...");
        }
    }


}
