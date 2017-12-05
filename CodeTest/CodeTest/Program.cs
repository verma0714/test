using System;

namespace CodeTest
{
    class Program
    {
        public static int GetANumber()
        {
            return 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + GetANumber());
            Console.ReadLine();
        }
    }
}
