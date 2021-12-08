using System;
using static System.Console;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = new char[10];
            char s = 'А';//Kirilica
            for (int i = 0; i < symbs.Length; i++)
            {
                if (s == 'А' || s == 'Ъ' || s == 'О' || s == 'У' || s == 'Е' || s == 'И')
                {
                    s++;
                }
                symbs[i] = s;
                WriteLine(symbs[i]);
                s++;
            }
            WriteLine();

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
