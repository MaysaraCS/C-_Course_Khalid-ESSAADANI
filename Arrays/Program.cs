using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = new string[2, 3];

            names[0,0] = "John";
            names[0,1] = "Jane";
            names[0,2] = "Doe";

            names[1,0] = "Alice";
            names[1,1] = "Bob";
            names[1,2] = "Charlie";

            foreach (string n in names)
            {
                Console.WriteLine("Hello:" + n);
            }
            Console.ReadKey();
        }
    }
}