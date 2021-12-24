using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _21_Threading
{
    class Program
    {
        const int x = 8;
        const int y = 7;
        static bool[,] garden = new bool[x, y];
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner2);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardner1();
            Console.ReadKey();
        }
        static void Gardner1()
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (garden[j, i] != true)
                        garden[j, i] = true;
                }
            }
        }
        static void Gardner2()
        {
            for (int j = x-1; j > 0; j--)
            {
                for (int i = y-1; i > 0; i--)
                {
                    if (garden[j, i] != true)
                        garden[j, i] = true;
                }
            }
        }
    }
}
