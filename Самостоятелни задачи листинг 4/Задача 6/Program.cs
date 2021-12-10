using System;
using static System.Console;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                int rgn = rnd.Next(1, 20);
                nums[i] = rgn;
            }
            Array.Sort(nums);
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Write(nums[i] + " ");
            }
            WriteLine();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
