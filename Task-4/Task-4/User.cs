using System;

namespace Task_4
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public uint Age { get; set; }

        public User() { }

        public void GetInfo()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.Age);
        }
    }
}
