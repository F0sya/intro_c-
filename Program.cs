using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            string result = "";
            for (int i =0; i < 4; i++)
            {
                number = Console.ReadLine();

                result = result + number;
            }
            Console.WriteLine(Convert.ToInt32(result));
        }
    }
}
