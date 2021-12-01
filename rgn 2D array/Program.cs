using System;
using static System.Console;

namespace rgn_2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] arrNums = new int[2, 3];

            for (int j = 0; j < arrNums.GetLength(1); j++)
            {
                for (int i = 0; i < arrNums.GetLength(0); i++)
                {
                    int cols = rnd.Next(1, 10);
                    arrNums[i, j] = cols;
                    int row = rnd.Next(1, 10);
                    arrNums[i, j] = row;
                }
            }

            WriteLine("Generated Array :");
            for (int c = 0; c < arrNums.GetLength(0); c++)
            {
                for (int f = 0; f < arrNums.GetLength(1); f++)
                {
                    Write(arrNums[c, f] + " ");
                }
                WriteLine();
            }
            WriteLine("Press eny key to close...");
            ReadKey(true);
        }
    }
}
