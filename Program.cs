using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;

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


            #region Fraction & Discard Video
            //12.35651214565487864556
            //float number = 12.35651214565487864556f;
            //Console.WriteLine(number);
            //float number2 = 10;
            //Console.WriteLine(number2);

            ////decimal number = 123.4567m;
            ////Console.WriteLine(number);
            //decimal number = 10 ;
            //Console.WriteLine(number);

            //float result = 3.0F / 2;
            //Console.WriteLine(result);

            //double number = 12.3456;
            //Console.WriteLine(number);

            // Discard , Digit Seprator C# 7.0 Feature [ _  out for Parameter ]

            //int number = 1000_000_000;
            //Console.WriteLine(number);
            //Console.WriteLine($"{number:c}");

            //CultureInfo CultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(number.ToString(CultureInfo));

            #endregion

            #region Implicit and Explicit Casting

            #region Ex 1 [ int - long ] 
            // Implicit Casting [ Safe Casting ] 
            // int x = 1000; // 4bytes 
            //long y ; // 8bytes
            //y = x; // Implicit = Safe Casting
            //Console.WriteLine(y);


            // Explicit Casting [ Not Safe Casting ]
            // Arthmethic OverFlow
            //checked
            //{
            //    long x = 1000;
            //    int y = (int)x;
            //    unchecked
            //    {
            //        Console.WriteLine(y);
            //    }

            //}
            //long x = 100000000000000; 
            //if (x > int.MaxValue || x < int.MinValue)
            //{
            //    Console.WriteLine("An exception hapeened");
            //}
            //else
            //{ 
            //    int y = (int)x; 
            //    Console.WriteLine(y);
            //}
            //object num = 12348888888888888885; 
            //if (num.GetType() == typeof(int))
            //{
            //    int x = (int)num;
            //    Console.WriteLine(x);
            //}

            //else
            //{
            //    Console.WriteLine("number is Large");
            //}

            #endregion

            #region Ex 2 [ int - Float ] 
            //Implicit int ==> float 
            //int x = 10; 
            //float y = x; // Implicit Casting [ Safe ]
            //Console.WriteLine(y); 

            // Explicit Casting Float ==> int 
            // float x = 12.55f 
            //int y = (int)x;
            //Console.WriteLine(y); // unsafe [ Loss Of Data ]


            #endregion

            #endregion


        }


    }

}
