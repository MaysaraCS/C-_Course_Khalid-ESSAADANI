using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Sealed_Classes
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void DisplayInfo();
    }
    class Programmer: Person
    {
        public string ProgrammingLanguage { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Programming Language: {ProgrammingLanguage}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer
            {
                Name = "Alice",
                Age = 30,
                ProgrammingLanguage = "C#"
            };
            programmer.DisplayInfo();
        }
    }
}