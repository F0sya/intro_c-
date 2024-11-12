using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(x);
            Console.Write(", ");
            Console.Write(y);
            Console.Write(", ");
            while (x+y < n)
            {
                int temp = y;
                y = x + y;
                x = temp;
                Console.Write(y);
                Console.Write(", ");
            }
        }
    }
}
