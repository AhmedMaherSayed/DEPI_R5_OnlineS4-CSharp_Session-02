namespace Session_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference Value
            //Point P1; // Zero Bytes Allocated at HEAP
            //P1 = new Point(1, 2);

            //// new 
            //// 1. Allocate Required Number of Bytes in the HEAP (Object Size + CLR Overhead Variables)
            //// 2. Initialize (Cross out) Allocated Bytes with Default Value of its Datatype
            //// 3. Call User-Defined Constructor if exists
            //// 4. Assign the Refence to the Allocated Object.

            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);
            //Console.WriteLine(P1.GetHashCode());

            //Point P2 = new Point();

            //P2.X = P1.X;
            //P2.Y = P1.Y;
            //Console.WriteLine(P2.X);
            //Console.WriteLine(P2.Y);
            //Console.WriteLine(P2.GetHashCode());

            //Console.WriteLine("Is P1 = P2 ? " + P2.Equals(P1)); // False


            //P2 = P1;

            //Console.WriteLine("-------------------- After -------------");
            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P2.GetHashCode());
            //Console.WriteLine("Is P1 = P2 ? " + P2.Equals(P1)); // True

            //P1.X = 10;
            //Console.WriteLine("P1.X = " + P1.X);
            //Console.WriteLine("P2.X = " + P2.X);
            #endregion

            #region Fraction and Discards
            //double X = 12.5;
            //float y = 1.25F;

            //decimal money = 12222.2224M;

            //money = 1_000_000;
            #endregion

            #region Value Type Casting
            // 1. Implicit Casting (Safe Casting)
            //int X = int.MaxValue;
            //long Y = X + 1;

            // 2. Explicit Casting (UnSafe Casting)
            //long X = int.MaxValue;
            //X += 100;

            //int Y;

            ////checked
            ////{
            ////    Y = (int)X;
            ////}

            //unchecked
            //{
            //    Y = (int)X;
            //}

            //Console.WriteLine("X = " + X + " Y = " + Y);

            //object x = 12;

            //int Y = (int)x;
            //Console.WriteLine(Y);

            // 3. Parse
            //Console.Write("Enter your integer: ");
            //int X = int.Parse(Console.ReadLine());

            //Console.WriteLine(++X);

            // 4. Convert
            //Console.Write("Enter your integer: ");
            //int X = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(++X);
            #endregion

            #region Operators

            #region Unary Operator
            // Unary Operators => works on One Operand (Variable)
            //int X = 10;
            // PreFix [Increment and then Print]
            //Console.WriteLine(++X);
            // PostFix [Print and then Increment]

            //Console.WriteLine(X++);
            //Console.WriteLine(X);

            // PreFix [Decrement and then Print]
            //Console.WriteLine(--X);

            // PostFix [Print and then Decrement]
            //Console.WriteLine(X--);
            //Console.WriteLine(X);
            #endregion

            #region Binary Operators
            // Binary Operators => Work on Two Operands (Variables)
            //int Sum, Mul, Div, Sub, Mod;
            //int Num01 = 2, Num02 = 6;
            //Sum = Num01 + Num02;
            //Sub = Num01 - Num02;
            //Mul = Num01 * Num02;
            //Div = Num01 / Num02;
            //Mod = Num01 % Num02;

            #endregion

            #region Assignment Operator
            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2
            #endregion



            #region Relational Operators [Comparsion]

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y); // Equal
            //Console.WriteLine(X != Y); // Not Equal
            //Console.WriteLine(X > Y);  // More Than
            //Console.WriteLine(X >= Y); // More Than Or Equal
            //Console.WriteLine(X < Y);  // Less Than
            //Console.WriteLine(X <= Y); // Less Than Or Equal


            #endregion


            #region Logical Operators

            //Console.WriteLine(!false);
            //Console.WriteLine(false && true); // Short Circuit
            //Console.WriteLine(true || false);

            //Console.WriteLine(4 < 5 && 7 < 9);

            #endregion


            #region Bitwise Operators

            //Console.WriteLine(!false);
            //Console.WriteLine(false & true); // Long Circuit
            //Console.WriteLine(true | false);

            //Console.WriteLine(4 < 5 & 7 < 9);

            #endregion

            #region Teranry Operator [Conditional Operator]

            //bool Flag = 4 > 2 ? true : false;
            //Console.WriteLine(Flag);
            //bool flag = true;

            //Console.ForegroundColor = flag ? ConsoleColor.Green : ConsoleColor.Red;

            //if (flag == true)
            //    Console.ForegroundColor = ConsoleColor.Green;
            //else
            //    Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine("Hello!");
            #endregion


            #region Operator Priorty [Precedence] and Associtvity

            /*
                     1. Unary Operator (PreFix)
                     2. Round Braces ()
                     3. * / %
                     4. + -
            */

            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;
            //e = (a + b) * c / d;     // ( 30 * 15 ) / 5

            //e = ((a + b) * c) / d;   // (30 * 15 ) / 5

            //e = (a + b) * (c / d);   // (30) * (15/5) 

            //e = a + (b * c) / d;    //  20 + (150/5)  
            #endregion

            #endregion

            #region String Formating
            int X = 4, Y = 2;

            string message = "Equation : " + X + " + " + Y + " = " + (X + Y);

            // String Interpolation
            //message = string.Format("Equiation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(message);

            // String Manipulation Operator
            message = $"Equation : {X} + {Y} = {X + Y}";
            Console.WriteLine(message);
            #endregion
        }
    }
}
