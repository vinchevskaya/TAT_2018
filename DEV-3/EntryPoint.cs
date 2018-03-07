using System;
using System.Text;

namespace DEV_3
{
    /// <summary>
    /// It is entry point of the program and it is print a number in the selected number system.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] arg)
        {
            try
            {
                int decimalNumber = Int32.Parse(arg[0]);
                if (decimalNumber < 0)
                {
                    throw new Exception("Can't convert negative numbers");
                }
                int newRadix = Int32.Parse(arg[1]);
                if (newRadix < 2 || newRadix > 20)
                {
                    throw new Exception("wrong Radix");
                }
                ConverterOfNumber conventer = new ConverterOfNumber(Int32.Parse(arg[0]), Int32.Parse(arg[1]));
                Console.WriteLine($"{conventer.СonvertDeciminalNumber()}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("ERROR: Wrong number of arguments");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
