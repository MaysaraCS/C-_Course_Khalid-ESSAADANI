using System;

namespace Delegates
{
    
        class string_manipulation
        {
            public static string TextCase(string Text)
            {
                if(Text == Text.ToUpper())
                {
                    return "Your text is capital ";
                }
                else if (Text == Text.ToLower())
                {
                    return "Your text is small ";
                }
                else
                {
                    return "Your text is mixed";
                }
            }
            public string TextLength(string Text)
            {
                return $"Your text has {Text.Length} characters";
            }
        }

    class Program
    {
        public delegate string myDelegate(string Text);
        static void Main(string[] args)
        {
            string_manipulation sm = new string_manipulation();
            myDelegate del1 = new myDelegate(string_manipulation.TextCase);
            myDelegate del2 = new myDelegate(sm.TextLength);

            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();

            Console.WriteLine(del1(text));
            Console.WriteLine(del2(text));
            Console.ReadKey();
        }
    }
}