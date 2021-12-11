using System;
using static System.Console;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNums = new int[3, 4];
            Random rnd = new Random();

            WriteLine("The array :");
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
            int[,] newnArr = new int[arrNums.GetLength(0) - 1, arrNums.GetLength(1) - 1];
            for (int i = 0; i < newnArr.GetLength(0); i++)
            {
                for (int j = 0; j < newnArr.GetLength(1); j++)
                {
                    newnArr[i, j] = arrNums[i, j];
                    Write(newnArr[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
