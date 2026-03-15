using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Struct_and_Enum
{
    class Program
    {   
        //struct Person
        //{
        //    public string FullName;
        //    public int Age;

        //}
        //static void Main(string[] args)
        //{
        //    Person p = new Person();
        //    Console.WriteLine("Enter your full name: ");
        //    p.FullName = Console.ReadLine();

        //    Console.WriteLine("Enter your age: ");
        //    p.Age = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Your name is {p.FullName} and you are {p.Age} years old.");
        //    Console.ReadKey();
        //}

        enum Status_Marital
        {
            single,
            married,  
            divorced
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marital status (single, married, divorced): ");
            string input = Console.ReadLine();
            switch(input)
            {
                case "single":
                    Console.WriteLine("You are single.");
                    break;
                case "married":
                    Console.WriteLine("You are married.");
                    break;
                case "divorced":
                    Console.WriteLine("You are divorced.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter single, married, or divorced.");
                    break;
            }
            Console.ReadKey();
        }
    }
}