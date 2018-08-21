using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜字串
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "Joy", "Patrick", "Cow", "Cindy" };
          
            int x = 0;
            for (int i = 0; i < a.Length; i += 1)
            {
                Console.Write(a[i] + " ");
                if (a[i].Contains("c"))
                {
                    x = x + 1;
                }
                else if (a[i].Contains("C"))
             {
                    x = x + 1;
                } }
            Console.WriteLine();
            Console.WriteLine("包含c的有" + x + "個");
            for (int y = 0; y < a.Length-1; y += 1)
            {
                int l = a[y].Length;
                int w = a[y + 1].Length;
                if (l >w )
                {
                    a[y + 1] = a[y];
                }
            }
            Console.WriteLine();
            Console.WriteLine("最長字串為" + a[a.Length - 1]);
        }
    }
}
