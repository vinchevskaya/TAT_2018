using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    /// <summary>
    /// This is Entry Point to the program.
    /// You need to enter login and password from the page VK.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            Login loginForInput = new Login();
            loginForInput.News(login, password);
        }
    }
}
