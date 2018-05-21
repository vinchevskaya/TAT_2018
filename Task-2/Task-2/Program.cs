using System;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(args[0]);
            int a = int.Parse(args[1]);

            try
            {
                if (b < 0 && a < 0)
                {
                    Console.WriteLine("Negative value.");
                    return;
                }

                if (b > int.MaxValue && a > int.MaxValue)
                {
                    Console.WriteLine("Too much value.");
                    return;
                }
                CalculatorAreaSquare calculator = new CalculatorAreaSquare(a, b);
                calculator.Calculator(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
