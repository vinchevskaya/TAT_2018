using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class InvokerCommand
    {
        ICommand command;

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ExecuteCommand(List<User> list)
        {
            command.Execute(list);
        }
    }
}
