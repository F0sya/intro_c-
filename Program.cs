using System.Net.NetworkInformation;
using System;
using System.Text;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first digit:");
            int firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit:");
            int secondDigit = Convert.ToInt32(Console.ReadLine());

            if(firstDigit > secondDigit)
            {
                (firstDigit, secondDigit) = (secondDigit, firstDigit);
            }

            for(int i = firstDigit; i < secondDigit; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
