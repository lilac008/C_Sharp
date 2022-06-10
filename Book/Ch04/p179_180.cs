using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p179_180
    {
        static void Main1(string[] args)
        {

            //continue   (현재 반복 중단, 다음으로 넘어감)

            for (int a = 1; a < 10; a++)
            {
                if (a % 2 == 0)
                {
                    continue;              //짝수일 경우, 현재 반복을 멈추고 다음 반복으로 넘어감. 따라서 아래의 코드는 실행되지 않는다.
                }
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();



            // !=   (다른 방법)               

            for (int a1 = 1; a1 < 10; a1++)
            {
                if (a1 % 2 != 0)
                {
                    Console.WriteLine(a1);
                }
            }
            Console.WriteLine();
            Console.WriteLine();















        }
    }
}
