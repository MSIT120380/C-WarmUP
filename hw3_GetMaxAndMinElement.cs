using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_GetMaxAndMinElement_取陣列最大最小值_
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 44, 66, 99, 100, 78, 2, 96, 55, 123, 253, 99, 4, 87 };
            Console.Write("nums = ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            
            SortArray(nums);
            Console.WriteLine("\n\nThe maximum of nums = {0}\n", nums[0]);
            Console.WriteLine("The minimum of nums = {0}\n\n", nums[nums.Length - 1]);

        }

        static void SortArray(int[] nums)    //bubble sort as ASC
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int temp = 0;
                    if(nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            
        }
    }
    
}
