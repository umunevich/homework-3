using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum, digit;
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            while (num > 0)
            {
                digit = num%10;
                sum += digit;
                num = num/10;
            }
            Console.WriteLine("The summa of digits is {0}", sum);
            Console.ReadKey(false);
        }
    }
}
