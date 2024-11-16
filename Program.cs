using System.Net.NetworkInformation;
using System;
using System.Text;

namespace intro_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть шестизначне число: ");
            string num = Console.ReadLine();
            if (num.Length != 6)
            {
                Console.WriteLine("Помилка: введіть саме шестизначне число.");
            }
            else
            {
                Console.Write("Введіть номер першого розряду для заміни: ");
                int firstDigit = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Введіть номер другого розряду для заміни: ");
                int secondDigit = Convert.ToInt32(Console.ReadLine()) - 1;
                StringBuilder sb = new StringBuilder();
                sb.Append(num);

                (sb[firstDigit], sb[secondDigit]) = (sb[secondDigit], sb[firstDigit]);
                Console.WriteLine(sb);
            }

        }
    }
}
