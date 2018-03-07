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
            if (Int32.Parse(arg[1]) > 2 || Int32.Parse(arg[1]) < 20)
            {
                ConverterOfNumber conventer = new ConverterOfNumber(Int32.Parse(arg[0]), Int32.Parse(arg[1]));
                Console.WriteLine($"{conventer.СonvertDeciminalNumber()}");
            }
        }
    }
}
