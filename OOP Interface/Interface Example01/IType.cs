using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface.Interface_Example01
{
    internal interface IType
    {
        // "Public" Access Modifier is the default access modifier for Interface
        // "Private" Access Modifier is not allowed in Interface for the signature Only (Properties, Methods,)



        // what U can write in interface

        // 1. Signature of Properties
        public int MyProperty { get; set; }

        // 2. Signature of Methods
        public void MyMethod();

        // 3. Defailt Implementation of Methods [C# 8.0 New Feature (.Net Core 3.1[2019])]
        public void Print()
        {
            Console.WriteLine("Defailt Implementation of Methods");
        }

        // 4. Static Members [C# 8.0 New Feature (.Net Core 3.1[2019])]
        // 4.1 Static Properties
        // 4.2 Static Methods
        // 4.3 Static Fields
        // 4.4 Static Events


    }
}
