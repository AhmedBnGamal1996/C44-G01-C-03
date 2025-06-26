using System;
using System.Diagnostics;
using System.Drawing;

namespace SessionThree
{

    internal class Program
    {
        //static void Print<T>(T value)
        //{
        //    Console.WriteLine(value);
        //}
        //static void TestPrint() {
        //    Print(10);
        //    Print<int>(10);
        //    Print("Mariam");
        //    Print(true);
        //}
        //static void PrintObj(object obj)
        //{

        //    Console.WriteLine(obj);
        //}
        //static void TestPrintObj()
        //{
        ////    PrintObj(10);   // Boxing

        ////    PrintObj("Mariam");
        ////    PrintObj(10.5);

        //}

        static void Main(String[] args)
        {
            #region Object
            //Object obj;
            //obj = 100;
            //obj = "100";
            //obj = "Mariam";
            //int result = 10 + (int)obj;
            //#endregion


            //#region ToString
            //Point  P1 = new Point() { X = 1 , Y = 2};
            //Console.WriteLine(P1.ToString());
            //int X = 1234;
            //Console.WriteLine(X.ToString()); 
            //object Num = 1234;
            //Console.WriteLine(Num.ToString());
            //object Name = "Mariam";
            //Console.WriteLine(Names.ToString());
            #endregion

            #region Equals
            //Point P1 = new Point() {X = 1,Y = 2};
            //Point P2 = new Point() { X = 1, Y = 2 };
            // P1 = P2;


            //Console.WriteLine(P1.Equals(P2)); // True

            //int X = 1234 , Y = 12345; 
            //Console.WriteLine(X.Equals(Y)); // False


            //object Num = 1234, Num2 = 12345;
            //Console.WriteLine(Num.Equals(Num2)); // False

            //string n = "Mariam", m = "Mariam";
            //object Name = "Mariam"; 
            //object Name2 = "mariam";
            //Console.WriteLine(Name.Equals(Name2));
            #endregion


            #region GetHashCode
            //Point P1 = new Point() {X = 1,Y = 2};
            //Point P2 = new Point() { X = 1, Y = 2 };
            //P1 = P2;
            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P2.GetHashCode());


            //int X = 1234 , Y = 1234; 
            //Console.WriteLine(X.GetHashCode());
            //Console.WriteLine(Y.GetHashCode());

            //object Name = "Mariam"; 
            //object Name2 = "mariam";
            //Console.WriteLine(Name.GetHashCode());  
            //Console.WriteLine(Name2.GetHashCode());
            #endregion



            #region GetType
            //Point P1 = new Point() { X = 1, Y = 2 };
            //Console.WriteLine(P1.GetType()) ;
            //object Name = "Mariam";
            //Console.WriteLine(Name.GetType());
            //int X = 1234;
            //Console.WriteLine(X.GetType());

            //object Num = 1234;
            //Console.WriteLine(Num.GetType());

            #endregion



            #region Example
            //object  obj = new object();
            //// Reference refer null 
            //// refer any instance of object or any data type that inhiret from object 
            //obj = 100; // Boxing 
            //obj = "Mariam";
            //obj = 100.5;
            //double s = (double) obj;    // UnBoxing


            #endregion

 

        }


    }

}
