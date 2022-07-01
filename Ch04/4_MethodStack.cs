using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 :  Stack  (p275)
///


namespace Ch04
{
    internal class _4_MethodStack
    {

        public static int Sum(int sta, int end)
        {
            int tot = 0;

            for (int k=sta; k <= end; k++)
            {
                tot += k;
            }
            return tot;
        }


        static void Main1(string[] args)
        {
            int result = 0;
            int a = 1;
            int b = 10;

            result = Sum(a, b);

            Console.WriteLine("결과 : " + result);
        }








    }
}
