﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Interface_Example02
{
    internal class TypeC : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 4;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
