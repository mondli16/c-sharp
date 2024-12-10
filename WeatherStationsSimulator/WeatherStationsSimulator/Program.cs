using System.Security;

namespace WeatherStationsSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature= new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] watherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                 watherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            Console.WriteLine($"The max temp is {temperature.Max()}");
            Console.WriteLine($"The min temp is {temperature.Min()}");
            Console.WriteLine($"The min temp is {MinTemp(temperature)}");
            Console.WriteLine($"The avarage temparature is {CalculateAverage(temperature)}");
            Console.WriteLine($"Most Common {MostCommonCondition(conditions)}");

        }
        static double CalculateAverage(int[] temperature)
        {
            int sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            double average = sum / temperature.Length;
            return average;
        }

        static int MinTemp(int[] temperature)
        { 
            int min = temperature[0];

            foreach (int i in temperature) 
            { 
            if (i < min)
                {
                    min= i;
                }
            }   
            return min;
        }

        static string MostCommonCondition(string[] condition)
        {
            int count = 0;
            string mostCommon = condition[0];

            for (int i = 0; i < condition.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < condition.Length; j++)
                {
                    if (condition[j] == condition[i])
                    {
                        tempCount++;
                    }
                    if(tempCount > count)
                    {
                        count = tempCount;
                        mostCommon = condition[i];

                    }
                    }

            }
            return mostCommon;
        }
        
    }
}
