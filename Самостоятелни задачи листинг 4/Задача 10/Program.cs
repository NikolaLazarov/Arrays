using System;
using static System.Console;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[,] arrNums = new int[4, 4];
            int t = arrNums.GetLength(0) - 1;
            Random rnd = new Random();

            WriteLine("Normal array :");
            for (int i = 0; i < arrNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrNums.GetLength(1); j++)
                {
                    int rgn = rnd.Next(1, 9);
                    arrNums[i, j] = rgn;
                    Write(arrNums[i, j] + " ");
                }
                WriteLine();
            }
            WriteLine("The new array :");
            for (int j = 0; j < arrNums.GetLength(0) - 2; j++)
            {
                for (int i = 0; i < arrNums.GetLength(1); i++)
                {
                    Write(arrNums[n, i] + " ");
                }
                WriteLine();
                for (int i = t; i >= 0; i--)
                {
                    Write(arrNums[n + 1, i] + " ");
                }
                WriteLine();
                n = n + 2;
            }



            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
