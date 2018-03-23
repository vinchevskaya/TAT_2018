using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Storage
    {
        ICommandStore command;

        public void SetCommand(ICommandStore com)
        {
            command = com;
        }

        public void WorkCommand(List<Shop> list)
        {
            command.Work(list);
        }
    }
}
