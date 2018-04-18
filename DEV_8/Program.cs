using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var users = new List<User>();
                var input = new UserBuilder();

                do
                {
                    var user = new UserBuilder();
                    Console.WriteLine("\n1) Input the first name:");
                    user.SetFirstName(Console.ReadLine());

                    Console.WriteLine("\n2) Input the surname:");
                    user.SetLastName((Console.ReadLine()));

                    Console.WriteLine("\n3) Input the age:");
                    user.SetAge(Console.ReadLine());

                    Console.WriteLine("\n4) Input the sex:");
                    user.SetGender(Console.ReadLine());

                    users.Add(user.Build());

                    Console.WriteLine("\nFor continue input press a");
                } while (Console.ReadKey(true).KeyChar == 'a');

                var invoker = new InvokerCommand();
                invoker.SetCommand(new AverageAge());
                invoker.ExecuteCommand(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
