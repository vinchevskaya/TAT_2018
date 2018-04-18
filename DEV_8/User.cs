using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Gender { get; set; }

        public uint Age { get; set; }

        public User() { }

        public void GetInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " " +
                              this.Gender + " " + this.Age);
        }
    }
}
