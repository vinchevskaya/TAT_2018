using System;
using System.Collections.Generic;

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
