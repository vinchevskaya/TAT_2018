﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public interface ICommandStore
    {
        void Work(List<Shop> list);
    }
}
