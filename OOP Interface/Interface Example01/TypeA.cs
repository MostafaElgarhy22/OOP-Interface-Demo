using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Interface_Example01
{
    internal class TypeA : IType  // Ctrl + . to implement the interface
    {
        public int MyProperty { get; set; } // Automatic Property

        public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}
