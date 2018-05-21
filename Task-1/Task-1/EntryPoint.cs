using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!\nAnd hi again!\n");
            Random random = new Random();
            int result = random.Next(5,50);
            for (int i=5; i < result; i++)
            {
                Console.Write("!");
            }                      
        }
    }
}
