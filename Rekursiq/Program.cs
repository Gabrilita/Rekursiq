
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursiq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 3;
            //for (int i1 = 1; i1 <= n; i1++)
            //{
            //    for (int i2 = 1; i2 <= n; i2++)
            //    {
            //        for (int i3 = 1; i3 <= n; i3++)
            //        {
            //            Console.WriteLine($"{i1} {i2} {i3}");
            //        }          
            //    }
            //}
            int n = 3;
            int k = 2;
            for (int i1 = 1; i1 <=n; i1++)
            {
                for (int i2 = i1; i2 <= n; i2++)
                {
                    Console.WriteLine($"{i1} {i2}");
                }
            }
        }
    }
}
