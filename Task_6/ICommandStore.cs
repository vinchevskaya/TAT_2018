using System;
using System.Collections.Generic;

namespace Task_6
{
    public interface ICommandStore
    {
        void Work(List<Shop> list);
    }
}
