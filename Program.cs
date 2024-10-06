using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Ввведите трёхзначное число N:");
            int N= int.Parse(Console.ReadLine());
            int units = N/100;
            int tens = N/10%10*10;
            int hundreds = N % 10 * 100;
            int X = units+tens+hundreds;
            Console.WriteLine("Искомое число X:" + X);
        Console.ReadKey();
        }
    }
}
