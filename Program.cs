using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Horizontal(1) or Vertical(2)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of line:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Symbol:");
            char symbol = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    for(int i = 0; i < length; i++)
                    {
                        Console.Write(symbol);
                    }
                    break;
                case 2:
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(symbol);
                    }
                    break;
            }
        }
    }
}
