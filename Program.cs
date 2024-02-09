using System;
using System.Linq;

namespace ProgrammMikky
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Hello", "World", "Hello", "Again" };

            string[] shortStrings = input
            .Where(s => s.Length <=3)
            .ToArray();

            Console.WriteLine("Короткие строки:");
            foreach (string s in shortStrings)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
            

            

