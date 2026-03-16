using System;

namespace new_and_override
{
    class Art
    {
        virtual public void Description()
        {
            Console.WriteLine("Art is the main class");
        }
    }
    class THeater :Art
    {
        new public void Description()
        {
            Console.WriteLine("Theater is the child class of Art");
        }
    }
    class Cinema : Art
    {
        public override void Description()
        {
            Console.WriteLine("Cinema is the child class of Art");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Art art = new Art();
            art.Description();

            THeater theater = new THeater();
            theater.Description();

            Cinema cinema = new Cinema();
            cinema.Description();
            
            Art art1 = new THeater();
            art1.Description();
            
            Art art2 = new Cinema();
            art2.Description();
        }
    }
}