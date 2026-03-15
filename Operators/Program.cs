using System.Text;
using System.Threading.Tasks;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // arithemetic operators
            int a = 10;
            int b = 20;
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));

            // test operators
            bool test = 5 < 6;
            Console.WriteLine("5 < 6 = " + test);

            // logical operators
            bool test2 = 5> 6 && 7 < 9;
            //bool test2 = 5 > 6 || 7 < 9;
            Console.WriteLine("5 > 6 && 7 < 9 = " + test2);
            Console.ReadKey();
        }
    }
}