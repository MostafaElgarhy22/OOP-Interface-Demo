using OOP_Interface.Interface_Example01;

namespace OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface Example 01
            //IType reference;
            //// Declare for refrence of type "IType" , contain Garbage Value
            //// This Refrence 'Reference' can refer to an object of any class that implements the IType interface
            //// CLR will Allocate 4 UnInitialized Bytes in the Stack of this refrence
            //// ClR will Allocate 0 Bytes in the Heap of this refrence

            ////  reference = //new IType(); // Error: Cannot create an instance of the interface 'IType'
            //reference = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod(); // Hello World
            //reference.Print(); // Default Implementation Method
            //TypeA typeA = new TypeA();
            //typeA.MyProperty = 10;
            //typeA.MyMethod();
            //typeA.Print();
            #endregion
        }
    }
}
