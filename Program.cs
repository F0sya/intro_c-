using System.Net.NetworkInformation;
using System;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max=0, min=0, sum=0, dobutok=1;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            max = x;
            min = x;
            for (int i = 0; i < 4; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x > max) { max = x; }
                if(x < min) { min = x; }
                sum = sum + x;
                dobutok = dobutok * x;
                Console.Clear();
            }
            Console.WriteLine($"Min:{min}\nMax:{max}\nSum:{sum}\nMultiply:{dobutok}");
        }
    }
}
