using System;
using static System.Console;

namespace Задача__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            Write("How many numbers  will you enter which when  you divide by 5 you have a 2 left out: ");
            int i = int.Parse(ReadLine());
            int[] nums = new int[i];

            Write("Enter those numbers(2,7,12,17,...): ");
            for (int j = 0; j < i; j++)
            {
                nums[j] = int.Parse(ReadLine());
                if (nums[j] % 5 != 2)
                {
                    WriteLine("Please enter numbers which are specified on top.");
                    y++;
                }
            }

            if (y > 0)
            {
                WriteLine();
            }
            else
            {
                WriteLine("Your array of numbers :");
                for (int j = 0; j < nums.Length; j++)
                {
                    Write(nums[j] + " ");
                    WriteLine();
                }

            }
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
