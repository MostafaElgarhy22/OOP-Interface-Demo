using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Interface_Example03
{
    internal class Airplane : Vechile, IMovable, IFlyable
    {
        void IMovable.Forward()
        {
            Console.WriteLine("Airplane is Moving Forward On Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane is Moving Forward On Air");
        }
    }
}
