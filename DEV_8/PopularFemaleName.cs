using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class PopularFemaleName : ICommand
    {
        private string result;
        public void Execute(List<User> list)
        {
            var womans = from user in list
                         where user.Gender == false
                         select user;

            int repeatMax = 0;
            int repeat;
            foreach (var woman in womans)
            {
                repeat = womans.Count(p => p.FirstName.Equals(woman.FirstName));
                if (repeatMax < repeat)
                {
                    repeatMax = repeat;
                    result = woman.FirstName;
                }
            }

            Console.WriteLine("The popular female name is {0}", result);
        }
        public string GetResult()
        {
            return result;
        }
    }
}
