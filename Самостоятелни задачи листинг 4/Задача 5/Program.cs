using System;
using static System.Console;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            Random rnd = new Random();

            for(int i =0;i<nums.Length;i++){
                int rgn = rnd.Next(1,25);
                nums[i] = rgn;
            }
            
            Array.Sort(nums);
            for(int i =0;i<nums.Length;i++){
                Write(nums[i]+" ");
            }
            WriteLine();

            for(int i =0;i<1;i++){
                if(nums[i] < nums[i+1]&&nums[i] < nums[i+2]&&nums[i] < nums[i+3]){
                    WriteLine("The lowest number is: "+nums[i]+".");
                }
                else if(nums[i+1] < nums[i]&&nums[i+1] < nums[i+2]&&nums[i+1] < nums[i+3]){
                  WriteLine("The lowest number is: "+nums[i+1]+".");   
                }
                else if(nums[i+2] < nums[i]&&nums[i+2] < nums[i+1]&&nums[i+2] < nums[i+3]){
                  WriteLine("The lowest number is: "+nums[i+2]+".");   
                }
                else if(nums[i+3] < nums[i]&&nums[i+3] < nums[i+1]&&nums[i+3] < nums[i+2]){
                  WriteLine("The lowest number is: "+nums[i+3]+".");   
                }
            }
            
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
    }
}
