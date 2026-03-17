using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void orderDelegare();
    class Product
    {
        private string label;
        private int quantity;
        public event orderDelegare orderEvent;

        // constructor
        public Product(string label, int quantity)
        {
            this.label = label;
            this.quantity = quantity;
        }
        // getters and setters
        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public void order(int number_of_products) 
        { 
            if(number_of_products > this.quantity) orderEvent();
            this.quantity = this.quantity - number_of_products;
        }
        public void messageEvenet() 
        {
            Console.WriteLine("Not enough products in stock!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop", 20);
            
            Console.WriteLine("Product: " + product.Label);
            Console.WriteLine("Quantity: " + product.Quantity);

            product.orderEvent += new orderDelegare(product.messageEvenet);
            product.order(60);
            
            Console.ReadKey();
        }
    }
}