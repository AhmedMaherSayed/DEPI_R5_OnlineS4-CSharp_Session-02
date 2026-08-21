namespace Session_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference Value
            Point P1; // Zero Bytes Allocated at HEAP
            P1 = new Point(1, 2);

            // new 
            // 1. Allocate Required Number of Bytes in the HEAP (Object Size + CLR Overhead Variables)
            // 2. Initialize (Cross out) Allocated Bytes with Default Value of its Datatype
            // 3. Call User-Defined Constructor if exists
            // 4. Assign the Refence to the Allocated Object.

            Console.WriteLine(P1.X);
            Console.WriteLine(P1.Y);
            Console.WriteLine(P1.GetHashCode());

            Point P2 = new Point();

            P2.X = P1.X;
            P2.Y = P1.Y;
            Console.WriteLine(P2.X);
            Console.WriteLine(P2.Y);
            Console.WriteLine(P2.GetHashCode());

            Console.WriteLine("Is P1 = P2 ? " + P2.Equals(P1)); // False


            P2 = P1;

            Console.WriteLine("-------------------- After -------------");
            Console.WriteLine(P1.GetHashCode());
            Console.WriteLine(P2.GetHashCode());
            Console.WriteLine("Is P1 = P2 ? " + P2.Equals(P1)); // True

            P1.X = 10;
            Console.WriteLine("P1.X = " + P1.X);
            Console.WriteLine("P2.X = " + P2.X);
            #endregion
        }
    }
}
