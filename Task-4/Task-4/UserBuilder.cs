using System;

namespace Task_4
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

        public User Build()
        {
            return user;
        }
    }
}
