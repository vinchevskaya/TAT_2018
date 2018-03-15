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
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
