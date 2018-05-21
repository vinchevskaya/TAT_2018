using System.Collections.Generic;

namespace Task_4
{
    interface ICommand
    {
        void Execute(List<User> list);
    }
}
