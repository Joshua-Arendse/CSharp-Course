namespace Enums
{
    // Enums is basically a set of constants.
    // It is immutable and should be set at namespace level
    // Immutable meaning it cannot be changed.
    enum Day { Mo,Tu,We,Th,Fr,Sa,Su};
    // you can set values for the enums
    enum Month { Jan=1,Feb,Mar,Apr,May,Jun,Jul=12,Aug,Sep,Oct,Nov,Dec};
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr==a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);

            Console.ReadKey();
        }
    }
}
