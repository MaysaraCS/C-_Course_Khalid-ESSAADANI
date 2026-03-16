using System;

namespace interfaces
{
    interface Quadrangle
    {
        int width { get; set; }
        int height { get; set; }
        float Area();
    }
    class Rectangle : Quadrangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        int Quadrangle.width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        int Quadrangle.height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        float Quadrangle.Area()
        {
            return this.width * this.height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrangle q = new Rectangle(5, 10);
            Console.WriteLine("Width: " + q.width);
            Console.WriteLine("Height: " + q.height);
            Console.WriteLine("Area: " + q.Area());
            Console.ReadKey();
        }
    }
}