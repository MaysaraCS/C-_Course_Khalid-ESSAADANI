using System.Text;
using System.Threading.Tasks;

namespace loops
    {
    class Program
    {
        static void Main(string[] args)
        {

            // Do .... While
            int number = 0;

            do
            {
                Console.WriteLine("Hello");
                number++;
            }
            while (number > 0 && number < 5);
            Console.ReadKey();

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For loop iteration: " + i);
            }
            // while loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("While loop iteration: " + j);
                j++;
            }
            // do-while loop
            int k = 0;
            do
            {
                Console.WriteLine("Do-while loop iteration: " + k);
                k++;
            } while (k < 5);
            // foreach loop
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (string name in names)
            {
                Console.WriteLine("Foreach loop iteration: " + name);
            }

        // while 
        ask: Console.WriteLine("Who is the first Khalifa? ");
            string KhalifaName = Console.ReadLine();

            while (KhalifaName != "Abu Bakr")
            {
                Console.WriteLine("False");
                goto ask;

            }
            Console.WriteLine("True");
            Console.ReadLine();
        }
    }
}