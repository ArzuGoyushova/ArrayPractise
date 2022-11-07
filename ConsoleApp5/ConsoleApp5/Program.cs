using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divided(42));
        }
        static bool Divided(int n)
        {
            return n % 21 == 0;

        }
    }
}
