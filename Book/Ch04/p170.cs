using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p170
    {
        static void Main1(string[] args)
        {

            //역으로 반복
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            for (int a = arr.Length - 1; a >= 0; a--)
            {
                Console.WriteLine(arr[a]);            // 결과 : 6,5,4,3,2,1
            }
            Console.WriteLine();
















        }
    }
}
