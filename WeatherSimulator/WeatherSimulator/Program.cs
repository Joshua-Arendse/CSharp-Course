namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Rainy", "Cloudy", "Snowy"};
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] =random.Next(-10,40);
                //weatherConditions[i] = conditions[random.Next(conditions.Length)];
                //Displays random weather condition

                if (temperature[i] <= 0)
                {
                    weatherConditions[i] = conditions[3];
                } else if (temperature[i] > 0 && temperature[i] < 25)
                {
                    weatherConditions[i] = conditions[random.Next(0,3)];
                }
                else
                {
                    weatherConditions[i] = conditions[0];
                }

                Console.WriteLine($"It is {temperature[i]} degrees and it is {weatherConditions[i]}");
            }

            Console.WriteLine($"Average Temperature is: {CalculateAverage(temperature)} degrees");
            Console.WriteLine($"The Max Temperature is: {temperature.Max()}");
            //Console.WriteLine($"The Min Temperature is: {temperature.Min()}");

            Console.WriteLine($"The Min Temperature is: {MinTemperature(temperature)}");
            //Using Method

            Console.WriteLine($"Most common condition is: {MostCommonCodition(weatherConditions)}");

            Console.ReadKey();
        }
        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature[i]; i++)
            {
                sum += temperature[i];
            }
            //temperature.Length is the amount of items inside of temperature
            double average = sum / temperature.Length;

            return average;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];
            foreach (int i in temperature)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        static string MostCommonCodition(string[] conditionsCheck)
        {
            int count = 0;
            string mostCommon = conditionsCheck[0];

            for (int i = 0;i < conditionsCheck.Length;i++)
            {
                int tempCount = 0;
                for(int j = 0; j < conditionsCheck[i].Length; j++)
                {
                    if (conditionsCheck[j]== conditionsCheck[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditionsCheck[i];
                }
            }
            return mostCommon;
        }
    }
}
