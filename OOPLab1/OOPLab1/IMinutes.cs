﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    interface IMinutes
    {
        int MinutesValue { get; set; }

        void Tick();
    }
}