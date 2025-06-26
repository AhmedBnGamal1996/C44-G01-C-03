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


            #region Casting [ Convert  - Parse - TryParse ] 
            // Ex : Enter Name , Age , Salary 
            //Console.WriteLine("Please Enter Your data ...");
            //Console.Write("Name : ");
            //string name = Console.ReadLine(); 

            //Console.WriteLine("Age : ");
            //int age; 
            //bool isAgeParsed = int.TryParse(Console.ReadLine() , out age);

            //Console.WriteLine("Salary : ");
            //double salary;
            //bool isSalaryParsed = Double.TryParse(Console.ReadLine(), out salary);


            //Console.Clear();
            //Console.Beep(37, 120);

            //Console.WriteLine($"Name : {name}"); 
            //Console.WriteLine($"Age : {age}"); 
            //Console.WriteLine($"Salary : {salary}");
            #endregion


            #region Operators


            #region Unary Operators
            // Unary == > Works on one Variable , on one operand 
            //int x = 10;
            //// 1] ++ ,,, x = x + 1 , X +=1 ; 
            //// [ Prefix : increment then before , Prefix print then increment ] 
            //Console.WriteLine("Initital Value " + x); // 10 
            //Console.WriteLine("++x " + ++x) ; // 11 [ Prefix Increment ]
            //Console.WriteLine("x++ " + x++); // 11 [ Postfix Increment ]
            //Console.WriteLine("Final Value : " + x ); // 12 

            //// 2] int y = 10;
            //// 1] ++ ,,, x = x + 1 , X +=1 ; 
            //// [ Prefix : Decrement then before , Prefix print then decrement ] 
            //Console.WriteLine("Initital Value " + y); // 10 
            //Console.WriteLine("--y " + --y); // 9 [ Prefix Increment ]
            //Console.WriteLine("y-- " + x--); // 9 [ Postfix Increment ]
            //Console.WriteLine("Final Value : " + x); // 9 

            #endregion

            #region Binary / Arthmetic Operators
            //// Binary operators ==> Between 2 operands / 2 variables
            //int a = 10, b = 5;
            //Console.WriteLine("Addition : " + (a+b) ); // 10+ 5 = 15 
            //Console.WriteLine("Subtraction : " + (a-b) ); // 10 - 5 = 5
            //Console.WriteLine("Multiplication : " + (a*b) ); // 10 * 5 = 50
            //Console.WriteLine("Division : " + (a/b) ); // 10 / 5 = 2
            //Console.WriteLine("Modulus : " + (a%3) ); // 10 % 3 = 1
            #endregion

            #region Assignement Operators

            //1] Simple Assignment
            //int a = 10 ;
            //Console.WriteLine("Simple Assignment : " + a ); // 10

            //2] Add and Assign [ a = a + 5 ]  
            //a += 5 ;
            //Console.WriteLine("Add and Assign (a += 5) :  " + a ); // 15

            //3] Subtract and Assign [ a = a - 3 ]  
            //a -= 3 ;
            //Console.WriteLine("Add and Assign (a -= 3) :  " + a ); // 12

            //4] Multiply and Assign [ a = a * 2 ]  
            //a *= 3 ;
            //Console.WriteLine("Multiply and Assign (a *=2) :  " + a ); // 24

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

            //// LessThan (<)
            //Console.WriteLine("a < b : " + (a < b)); //False

            //// Lesserthan and Equal To  ( >= ) 
            //Console.WriteLine("a >= b : " + (a >= b));//true

            //// Greater Than and Equal To  ( <= ) 
            //Console.WriteLine("a <= b : " + (a <= b));//False

            #endregion

            #region Logical Operators

            //// Short Circut 
            //bool A = true, B = false;
            ////Logical Not 

            //Console.WriteLine("!A : " + (!A));     // !true = False 
            //Console.WriteLine("!B : " + (!B));     // !False = true 

            //// Logical And && [ Short Circut ] 
            //// true && true ==> true 
            //// true && False ==> False
            //// false && true ==> false
            //// false && false ==> false 
            //Console.WriteLine("B && A : " + (B && A)); // false && true = false

            //// Logical OR || [ Short Circut ]  
            //// true && true ==> true 
            //// true && False ==> true
            //// false && true ==> true
            //// false && false ==> false 
            //Console.WriteLine("B ||A : " + (B ||A)); // true|| false = true 

            //#endregion


            #endregion



            #region Bitwise Operators


            //int A = 5; // Binary = 0101
            //int B = 3; // Binary = 0011

            ////Bitwise And & 

            //// true && true ==> true 
            //// true && False ==> False
            //// false && true ==> false
            //// false && false ==> false 
            //Console.WriteLine("A & B : " + (A & B)); // 1 = 0001 Binary 

            //// Bitwise OR |  
            //// true && true ==> true 
            //// true && False ==> true
            //// false && true ==> true
            //// false && false ==> false 
            //Console.WriteLine("A |B : " + (A | B)); // 7 = 0111


            //// BitWise XOR 
            //// 0 ^ 1 = 1 
            //// 1 ^ 0 = 1 
            //// 0 ^ 0 = 0
            //// 1 ^ 1 = 0
            //Console.WriteLine(" a ^ b : " + ( A ^ B ) ); // 6 = 0110 

            //// BitWise NOT

            //Console.WriteLine(" ~a : " + (~A));  //-6 = (2's compl

            //// Left Shift 
            //Console.WriteLine(" a << 1 : " + (A << 1)); // 10 = 1010 

            //// RightShift 
            //Console.WriteLine(" a >> 1 : " + (A >> 1)); // 2 = 0010 

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

            //int equation5 = (a + b) % c;
            //Console.WriteLine("equation 5 : " + equation5);

            //int equation6 = a + b++;
            //Console.WriteLine("equation 6 : " + equation6);


            //int equation7 = a + ++b;
            //Console.WriteLine("equation 7 : " + equation7);
            #endregion

            #region String Format 
           
            #endregion
        }


    }

}
#endregion