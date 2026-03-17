using System;
using System.Collections.Generic;

namespace Lambda
{
    public delegate void meDelegate();
    class Absence
    {
        public event meDelegate AbsenceEvent;
        private int absentHours;

        // getter and setter for absentHours
        public int AbsentHours
        {
            get { return absentHours; }
            set { absentHours = value; }
        }
        public Absence(int Hours)
        {
            this.absentHours = Hours;
        }
        public void verifyAbsence(int MAX_Hours)
        {
            if (absentHours > MAX_Hours)
            {
                // do event 
                AbsenceEvent();
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Absence absence = new Absence(10);

            absence.AbsenceEvent += ()=> Console.WriteLine("You have exceeded the maximum allowed hours of absence.");
            
            absence.verifyAbsence(8);

            List<string> Colors = new List<string>() { "Red", "Green", "Blue", "Yellow" };
            Console.WriteLine("Colors in the list:");
            Colors.ForEach(color =>
            {
                Console.WriteLine("\t - " + color);
            });
            Console.ReadKey();
        }
    }

}