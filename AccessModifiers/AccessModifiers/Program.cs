namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();
            
            
            Console.ReadKey();
        }
    }

    class BaseClass
    {
        // access modifiers
        public int publicField; // Acccessible anyt=where in the program
        protected int protectedField; // Accessible in the class it is declared and in all subclasses
        private int privateField; // Accessible only within the same class

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            //privateField = 3;
        }
    }
}
