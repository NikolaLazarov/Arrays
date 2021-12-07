using System;
using static System.Console;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = new char[10];
            char s = 'a';

            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = s;
                s++;
                s++;
            }
            for (int i = 0; i < symbs.Length; i++)
            {
                WriteLine(symbs[i]);
            }
            WriteLine("-----");
            for (int i = 9; i >= 0; i--)
            {
                WriteLine(symbs[i]);
            }
            WriteLine();
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
