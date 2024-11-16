using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a percent:");
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((number/100) * percent);
        }
    }
}
