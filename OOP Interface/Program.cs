﻿using OOP_Interface.Interface_Example01;
using OOP_Interface.Interface_Example03;

namespace OOP_Interface.Interface_Example02
{

    internal class Program
    {
        #region Interface Example 02
        //static void PrintTenNumbersFromSeries(ISeries series)
        //{
        //    if (series is null) 
        //        return;
        //    for (int i = 1;  i <= 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.GetNext();               
        //    }

        //    series.Reset();
        //    Console.WriteLine();
        //}
        #endregion
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
            #region Interface Example 02

            //TypeA seriesByTwo = new TypeA();
            //PrintTenNumbersFromSeries(seriesByTwo);

            //Type_B seriesByThree = new Type_B();
            //PrintTenNumbersFromSeries(seriesByThree);

            //TypeC serirsByFour = new TypeC();
            //PrintTenNumbersFromSeries(serirsByFour);
            #endregion
            #region Interface Example 03

            Airplane airplane = new Airplane();
            airplane.Speed = 520;

            IMovable movable = airplane;
            movable.Forward();

            IFlyable flyable = airplane;
            flyable.Forward();

            #endregion
        }
    }
}
