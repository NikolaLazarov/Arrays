using System;
using static System.Console;


namespace Листинг__4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] symbs = new char[5][];
            int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };

            char s = 'A';
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = new char[i + 3];
                for (int j = 0; j < symbs[i].Length; j++)
                {
                    symbs[i][j] = s;
                    s++;
                }
            }
            WriteLine("Whole numbers array : ");
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Write("{0,3}", nums[i][j]);
                }
                WriteLine();
            }
            WriteLine("Symbols array : ");
            foreach (char[] q in symbs)
            {
                foreach (char p in q)
                {
                    Write("{0,2}", p);
                }
                WriteLine();
            }
            ReadKey(true);
        }
    }
}
