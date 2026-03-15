using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "First C# Project";
            Console.Write("Write your name: ");
            string name = Console.ReadLine();

            Console.Write("Write your age: ");
            int age = int.Parse(Console.ReadLine());
            //int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello, {name}!, your age is: {age}");

            Console.ReadKey();
        }
    }
}