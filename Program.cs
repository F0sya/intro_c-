using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            int B = Convert.ToInt32(Console.ReadLine());

            while(A <= B)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write($"{A} ");
                }
                A++;
                Console.Write("\n");
            }
        }
    }
}
