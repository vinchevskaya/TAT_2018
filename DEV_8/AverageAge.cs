using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    public class AverageAge : ICommand
    {
        private double result;

        public void Execute(List<User> list)
        {
            foreach (var user in list)
            {
                result = list.Average(p => p.Age);
            }

            Console.WriteLine("Average age is: {0}", result);
        }
        public double GetResult()
        {
            return result;
        }
    }
}
