using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class OldestUser : ICommand
    {
        private IEnumerable<User> result;

        public void Execute(List<User> list)
        {
            uint maxAge = 0;

            foreach (var user in list)
            {
                if (maxAge < user.Age)
                {
                    maxAge = user.Age;
                }
            }

            result = from oldestUser in list
                     where oldestUser.Age == maxAge
                     select oldestUser;

            foreach (var man in result)
            {
                Console.WriteLine(man.ToString());
            }
        }
        public IEnumerable<User> GetResult()
        {
            return result;
        }
    }
}
