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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Условия задачи:");
            Console.WriteLine("");
            Console.WriteLine("В трехзначном числе x зачеркнули последнюю цифру. " +
                "Когда в оставшемся двузначном числе поменяли порядок цифр и приписали вычеркнутую цифру слева, получилось число n. " +
                "По заданному числу n (ввод с клавиатуры и число единиц не равно нулю) найти число x.");
            Console.WriteLine("");
            Console.ResetColor();
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
