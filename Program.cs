using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;

namespace SessionThree
{

    internal class Program
    {
        public Program()
        {
        }

        static void Main(String[] args)
        {
            #region Generics
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
            #endregion


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


            #region Casting [ Convert  - Parse - TryParse ] 
            // Ex : Enter Name , Age , Salary 
            //Console.WriteLine("Please Enter Your data ...");
            //Console.Write("Name : ");
            //string name = Console.ReadLine(); 

            //Console.WriteLine("Age : ");
            //int age; 
            //bool isAgeParsed = int.TryParse(Console.ReadLine() , out age);

            //5] Divide and Assign [ a = a / 5 ]  
            //a /= 5 ;
            //Console.WriteLine("Multiply and Assign (a /=2) :  " + a ); // 2


            //5] Modulus and Assign [ a = a % 5 ]  
            //a %= 5 ;
            //Console.WriteLine("Multiply and Assign (a %=5) :  " + a ); // 2

            #endregion


            #region Retional Operators [ Comparsion ] 
            //// return bool [ true , false ] 
            // int a = 10 , b = 5 ; 
            ////Equal to ( == ) 
            //Console.WriteLine("a== b : " + (a == b)); // false 
            //// Not  Equal to (!=) 
            //Console.WriteLine("a!=b : "+ (a != b)); // true
            //// Greater Than (> )
            //Console.WriteLine("a > b : " + (a > b)); //true 


            #endregion


            #region Ternary Operators
            //int a = 10 , b = 20 ;
            //string result;
            //// Example : Simple Comparsion 
            //if (a > b)
            //{
            //    result = "a is greater ";
            //}
            //else if (a < b)
            //{
            //    result = "b is greater ";
            //}
            //else
            //{
            //    result = "a equals b"; 
            //}

            //result = (a > b) ? "a is greater " : "b is greater ";
            //result = (a > b) ? "a is greater " : (b > a) ? "b is greater " : "a equal b ";


            #endregion

            #region operators Priority [ Presedence ] 
            //int a = 10, b = 20, c = 30;
            //int equation3 = (a + b) - c;
            //Console.WriteLine("equation 3 : " + equation3);

            //int equation4 = a + b * c;
            //Console.WriteLine("equation 4 : " + equation4);

            ////// String Interpolation
            ////string msg = $"Equation : {x} + {y} = {result} ";  
            ////Console.WriteLine(msg);
            ////Console.WriteLine($"Equaltion : {x} + {y} = {result}");
            ////Console.WriteLine(15);
            ////Console.WriteLine(true);

            //// Format Function 
            //string msg = string.Format("Equation : {0} + {1} = {2}", x, y, result); 
            //    Console.WriteLine(msg);

            //// String Cocatenation [ + ]
            //// int x = 10, y = 5, result = x + y;
            //string msg = "equation " + ": " + x + "+" + y + "y" + "= " + result;

            //// Equation 
            //// Equation :
            //// Equation :  10  
            //// Equation :  10 +  
            //// Equation :  10 + 5  
            //// Equation :  10 + 5  =  
            //// Equation :  10 + 5  = 15  

            //Console.WriteLine("Equation : " + x + " + " y + "= " + result);

            //// D:C44--Route\02 C#\SessionThreeGroupTwoSoulation\SessionThree

            //string filePath = @"D:C44--Route\\02 C#\\SessionThreeGroupTwoSoulation\\SessionThree"
            //Console.WriteLine(filePath);

            //string msg = "Mariam \t shindy";
            //Console.WriteLine(msg);

            #endregion











            #region Assignment 3 


            #region Task 
            /*
             * Ask user for salary amount and print:    
             * "No tax" if < 5000 , and the salary stays the same.
             * "10% tax" if between 5000–9999 ,  subtract 10% tax.
             * "20% tax" if ≥ 10000 ,  subtract 20% tax.
             * Expected output : 
             * ==> 10% tax applied  
             * ==> Final salary after tax 
             */

            //Console.WriteLine("Enter your Salary : ");  
            //double salary; 
            //bool isSalary = double.TryParse(Console.ReadLine(), out salary);
            //if (isSalary is true && salary < 5000)
            //{
            //    Console.WriteLine("No Tax For Your Salary ." );
            //}
            //else if (isSalary is true && salary >= 5000 && salary <= 9999)
            //{
            //    salary = salary * 0.1;
            //    Console.WriteLine($"your Salary is {salary} , 10% tax ");
            //}
            //else if (isSalary is true && salary >=10000 )
            //{
            //    salary = salary * 0.2;
            //    Console.WriteLine($"your Salary is {salary} , 20% tax ");
            //}
            //else        // refer put For Loob here Enter Again 
            //{
            //    Console.WriteLine("Try Enter Your Salary Again ");
            //}



            #endregion

            #region 1-Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter Any Number");
            //int number; 
            //bool isNumber = int.TryParse(Console.ReadLine() , out number);
            //Console.Clear(); 
            //if (number.GetType() == typeof(int))
            //{
            //    Console.WriteLine($"Your Number is {number} ");
            //}

            //else
            //{
            //    Console.WriteLine("Enter Agian");
            //}

            #endregion


            #region 2- Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.WriteLine("enter any number : ");
            //string numberString = Console.ReadLine();

            //checked
            //{
            //int number ; 
            //   bool isConvertNumber = int.TryParse(numberString, out number);
            //    if (isConvertNumber is true)            ///Can not Convert String to int 
            //    {
            //        Console.WriteLine(number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("this is propblem .");
            //    }
            //}

            #endregion

            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 10 , num2 = 20  , result = num1*num2 ;
            //Console.WriteLine(result);        // result = 200

            #endregion

            #region 4-Write C# program that Extract a substring from a given string.
            //Console.WriteLine("Please write any text");  // hello my friend
            //string sourceString = Console.ReadLine();
            //Console.WriteLine("Please write text search");
            //string data = Console.ReadLine();               // hello
            //Console.Clear(); 
            //int startIndex = sourceString.IndexOf(data);
            //if (startIndex != -1)
            //{
            //    string subString = sourceString.Substring(startIndex, data.Length);
            //    Console.WriteLine($"your seach is found : {subString}");                // hello
            //}
            //else {
            //    Console.WriteLine("please try agian another text");
            //}



            #endregion

            #region 5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            #endregion

            #region 6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            #endregion

            #region 7-Write C# program that take two string variables and print them as one variable
            //Console.WriteLine("Please write FisrtName");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Please write LastName");
            //string lastName = Console.ReadLine();
            //string result = firstName + lastName ;
            //Console.WriteLine($"your name is  {result}");

            #endregion

            #region 8-Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.


            #endregion

            #region 9-Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)


            #endregion

            #region 10-Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001


            #endregion

            #region 11-What is the output of the following C# code?
            /*  
             DateTime date = new DateTime(2024, 6, 14);
             Console.WriteLine($"The event is on {date:MM/dd/yyyy}");*/
            #endregion

            #region 12-Which of the following statements is correct about the C#.NET code snippet given below?
            /*
             * int d; 
             * d = Convert.ToInt32( !(30 < 20) );
             */
            #endregion

            #region 13-Which of the following is the correct output for the C# code given below?
            /*Console.WriteLine(13 / 2 + " " + 13 % 2); */

            #endregion




            }
    }
    }


#endregion