using System;
using static System.Console;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[2, 3];
            int[,] arrnums = new int[3, 2];
            Random rnd = new Random();

            WriteLine("The array :");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    int rgn = rnd.Next(1, 9);
                    nums[i, j] = rgn;
                    Write(nums[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("The new array :");
            for (int i = 0; i < arrnums.GetLength(0); i++)
            {
                for (int j = 0; j < arrnums.GetLength(1); j++)
                {
                    arrnums[0, 0] = nums[1, 0];
                    arrnums[0, 1] = nums[0, 0];
                    arrnums[1, 0] = nums[1, 1];
                    arrnums[1, 1] = nums[0, 1];
                    arrnums[2, 0] = nums[1, 2];
                    arrnums[2, 1] = nums[];

                    Write(arrnums[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
