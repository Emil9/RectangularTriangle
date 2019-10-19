using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            Console.Write("Podaj liczbę naturalną n>4, n= ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 4)
            {
                Console.WriteLine("Liczba n musi być większe od 4");
            }
            else
            {
                for (k = n; k > 1; k--)
                    Console.Write(" ");
                Console.WriteLine("X");
                for (k = n - 1; k > 1; k--)
                    Console.Write(" ");
                for (i = 1; i < n - 1; i++)
                {
                    Console.Write("X");
                    for (j = 1; j < i; j++)
                        Console.Write(" ");
                    Console.WriteLine("X");
                    for (k = n - 2; k > i; k--)
                        Console.Write(" ");
                }
                for (i = 0; i < n; i++)
                    Console.Write("X");
            }
            Console.ReadKey(true);
        }
    }
}
