using System;

namespace Истинският_Листинг_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3, cols = 5;
            int[,] nums = new int[rows, cols];
            int value = 1;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int u = 0; u < nums.GetLength(1); u++)
                {
                    nums[i, u] = value;
                    value++;

                    Console.Write(nums[i, u] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
