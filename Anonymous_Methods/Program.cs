using System;

namespace Anonymous_Methods 
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
        //public void alertEvent()
        //{
        //    Console.WriteLine("Alert: Absence hours exceeded the maximum limit!");
        //}
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            Absence absence = new Absence(10);
            // subscribe to the event
            //absence.AbsenceEvent += new meDelegate(absence.alertEvent);
            
            // subscribe to the event using an anonymous method
            absence.AbsenceEvent += delegate() 
            {
                Console.WriteLine("Alert: Absence hours exceeded the maximum limit!");
            };
            absence.verifyAbsence(8);
            Console.ReadKey();  
        }
    }

}