using System;
using System.Text;

namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] arg)
        {
            if (arg.Length != 2)
            {
                Console.Write("Wrong number of arguments");
            }
            else
            {
                if (Int32.Parse(arg[1]) > 2 || Int32.Parse(arg[1]) < 20)
                {
                    ConverterOfNumber conventer = new ConverterOfNumber(Int32.Parse(arg[0]), Int32.Parse(arg[1]));
                    Console.WriteLine($"Converted number: {conventer.СonvertDeciminalNumber()}");
                }
            }
        }
    }
}
