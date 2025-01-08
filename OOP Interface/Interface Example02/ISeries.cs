using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Interface_Example02
{
    internal interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();

        public void Reset();
    }
}
