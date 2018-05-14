using System;
using WebService;

namespace DEV_11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int day, month, year;
                Console.WriteLine("Day");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Month");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Year");
                year = Convert.ToInt32(Console.ReadLine());
                DateConverter webServis = new DateConverter();
                Console.WriteLine("Number of days after the birthday of Jesus: " + webServis.DaysCounter(day, month, year));

            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
