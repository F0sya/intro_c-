using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            while(x > 0)
            {
                Console.Write(x%10);
                x = x / 10;
            }
        }
    }
}
