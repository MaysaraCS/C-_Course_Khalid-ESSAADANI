using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraameters
{
    class program 
    {
        static void myProcedure (ref int Number)
        {
            Number = 10;
            // pass by value
            Console.WriteLine("The value during passing is :" + Number);
        }
        static void Main(string[] args)
        {
            int Num = 20;

            Console.WriteLine("The value before passing is :" + Num);
            //myProcedure(Num);
            //Console.WriteLine("The value after passing is :" + Num);

            // pass by reference
            myProcedure(ref Num);
            Console.WriteLine("The value after passing is :" + Num);

            Console.ReadKey();

        }
    }
}