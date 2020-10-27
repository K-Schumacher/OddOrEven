using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd();
        }

        public static bool IsOdd()
        {
            Console.WriteLine($"Enter a number to determine if it is even or odd.");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();

            if (number % 2 != 0)
            {
                Console.WriteLine($"We have determined that {number} is odd.");
                return true;
            }
            else
            {
                Console.WriteLine($"We have determined that {number} is even.");
                return false;
            }
        }
    }
}
