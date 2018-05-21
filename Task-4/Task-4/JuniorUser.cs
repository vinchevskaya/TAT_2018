using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4
{
    class JuniorUser : ICommand
    {
        private IEnumerable<User> result;

        public void Execute(List<User> list)
        {
            uint minAge = 0;

            foreach (var user in list)
            {
                if (minAge < user.Age)
                {
                    minAge = user.Age;
                }
            }

            result = from juniorUser in list
                     where juniorUser.Age == minAge
                     select juniorUser;

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
