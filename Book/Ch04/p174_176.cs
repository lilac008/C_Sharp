using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p174_176
    {
        static void Main1(string[] args)
        {

            //중첩 반복




            // 별 피라미드                   
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < a + 1; b++)
                    Console.Write('*');
                Console.Write('\n');
            }


            // 별 피라미드 2
            for (int a1 = 0; a1 < 10; a1++)
            {
                for (int b1 = 0; b1 < 10 - a1; b1++)
                    Console.Write(' ');
                for (int b1 = 0; b1 < a1 + 1; b1++)
                    Console.Write('*');
                Console.Write('\n');
            }



























        }
    }
}
