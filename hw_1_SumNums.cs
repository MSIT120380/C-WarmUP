using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_SumOfArithmeticProgression_等差級數_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("1 + 3 + ... + 99 = SUM\n");
            for (int i = 0; i < 50; i++)        //for loop
            {
                sum = sum + i * 2 + 1;
            }
            Console.WriteLine("SUM = " + sum + "\t use for-loop");

            sum = 0;
            int x = 1;
            while (x <= 99)         //while loop
            {
                sum = sum + x;
                x = x + 2;
            }
            Console.WriteLine("SUM = " + sum + "\t use while-loop");

            sum = 0;
            x = 1;
            do                      //do loop
            {
                sum = sum + x;
                x = x + 2;

            } while (x <= 99);
            Console.WriteLine("SUM = " + sum + "\t use do-loop\n");

        }

    }
}
