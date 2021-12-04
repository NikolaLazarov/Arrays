using System;
using static System.Console;

namespace Листинг_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] objs = new Object[3];
            objs[0] = 123;
            objs[1] = 'A';
            objs[3] = "Third element";
            WriteLine("An array is made : ");
            for (int k = 0; k < objs.Length; k++)
            {
                WriteLine(k + ": " + objs[k]);
            }
            objs[0] = (int)objs[0] + 111;
            objs[1] = "Second Element";
            objs[2] = 3.141592;
            WriteLine("After  adding up  to  the values : ");
            for (int k = 0; k < objs.Length; k++)
            {
                WriteLine(k + ": " + objs[k]);
            }
            int[] nums = { 10, 20, 30 };
            objs[2] = nums;
            WriteLine("Whole numbers array : ");
            for (int k = 0; k < ((int[])objs[2]).Length; k++)
            {
                Write("{0,3}", ((int[])objs[2])[k]);
            }
            WriteLine();
            ((int[])objs[2])[1] = 0;
            WriteLine("One more time the same array");
            for (int i = 0; i < nums.Length; i++)
            {
                Write("{0,3}", nums[i]);
            }
            WriteLine();
            ReadKey(true);
        }
    }
}
