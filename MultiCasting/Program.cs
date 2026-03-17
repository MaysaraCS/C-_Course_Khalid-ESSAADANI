using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCasting
{
    class MultiCast
    {
        public static void Sinus(int number)
        {
            Console.WriteLine($"Sinus is: {Math.Sin(number)}");
        }
        public static void Cosinus(int number)
        {
            Console.WriteLine($"Cosinus is: {Math.Cos(number)}");
        }
    }
    
    public delegate void MyDelegate(int number);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate D1 = MultiCast.Sinus;
            MyDelegate D2 = MultiCast.Cosinus;
            Console.WriteLine("<------------Simple Delegate--------->");
            D1(60);
            D2.Invoke(180);

            Console.WriteLine("<------------Combining Delegates--------->");
            Console.WriteLine("<------------MultiCast Delegate--------->");
            MyDelegate MultiCastDelegate = D1 + D2;
            MultiCastDelegate(90);
            Console.ReadLine();
        }
    }
}