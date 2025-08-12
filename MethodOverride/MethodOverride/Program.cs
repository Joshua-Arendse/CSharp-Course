namespace MethodOverride //Part of Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();

            Cat myCat = new Cat();
            myCat.MakeSound();

            Console.ReadKey();
        }
    }
    // Base CLass (Parent Class or Superclass): The class whose members are inherited
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound() //Virtual keyword in base class makes it possible to override the method.
        {
            Console.WriteLine("Animal makes generic sound.");
        }
    }

    // Derived Class (Child or Subclass):
    // The class that inherits the members of the base class.
    class Dog : Animal
    {
        public override void MakeSound() // override keyword in subclass.
        {
            base.MakeSound(); //Accessing the base class MakeSound() method (USed when you dint have access to the base class)
            Console.WriteLine("Barking...");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
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
