using System;

namespace Virtual_Methods
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void DisplayInfo();
        public void PrintMessage()
        {
            Console.WriteLine("This is a message from the Person class.");
        }
        virtual public void work()
        {
            Console.WriteLine("This is a work method from the Person class.");
        }
    }
    class Programmer : Person
    {
        public string ProgrammingLanguage { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Programming Language: {ProgrammingLanguage}");
        }
        public override void work()
        {
            // from main class 
            base.work();
            // from derived class 
            Console.WriteLine("hello this is the programmer ");
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
            programmer.work();
            programmer.PrintMessage();
            Console.ReadKey();
        }
    }
}