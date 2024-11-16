using System.Net.NetworkInformation;
using System;
using System.Text;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature:");
            double temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("To Celsius(1) or Fahrenheint(2)?");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write($"Temperature in Celsius: {temp} F = {(temp-32)*5/9} C");
                    break;
                case 2:
                    Console.Write($"Temperature in Fahreheint: {temp} C = {(temp * 9 / 5) + 32} F");
                    break;
            }
        }
    }
}
