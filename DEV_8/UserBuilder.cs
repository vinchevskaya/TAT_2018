using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    public class UserBuilder
    {
        private User user;

        public UserBuilder()
        {
            user = new User();
        }

        public void SetFirstName(string name)
        {
            if (name.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            user.FirstName = name;
        }

        public void SetLastName(string lastName)
        {
            if (lastName.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            user.LastName = lastName;
        }

        public void SetAge(string age)
        {
            user.Age = UInt32.Parse(age);
        }

        public void SetGender(string gender)
        {
            if (gender != "man" && gender != "woman")
            {
                throw new ArgumentException();
            }

            if (gender == "man") user.Gender = true;
            else user.Gender = false;
        }

        public User Build()
        {
            return user;
        }
    }
}
