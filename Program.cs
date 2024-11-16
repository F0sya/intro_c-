using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 100)
                {
                    throw new Exception("Number need to be 0 < x < 100;");
                }
                if (number % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (number % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (number % 3 != 0) 
                {
                    Console.Write(number);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
