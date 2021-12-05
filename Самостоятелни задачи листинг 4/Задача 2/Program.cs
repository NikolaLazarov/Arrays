using System;
using static System.Console;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[11];
            int n = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = n;
                n = n * 2;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Write(nums[i] + "");
                WriteLine();
            }
            n=1024;
            WriteLine("-----");
            for (int i = 11; i < nums.Length; i--)
            {
                nums[i] = n;
                n = n / 2;
            }
            for (int i = 10; i >= 0; i--)
            {
                Write(nums[i] + "");
                WriteLine();
            }

            WriteLine("Press nay key to close...");
            ReadKey(true);
        }
    }
}
