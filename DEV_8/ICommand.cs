﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    interface ICommand
    {
        void Execute(List<User> list);
    }
}
