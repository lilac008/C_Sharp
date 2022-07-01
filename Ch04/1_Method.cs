using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : Method   (p265)
///
///     (F11눌러서 흐름 확인하기)


namespace Ch04
{
    internal class _1_Method
    {

        static void Main1(string[] args)
        {
            ///1                                           method는 대문자가 원칙이지만 함수를 표시하기 위해 이렇게 나타냄
            int r1 = f(1);                               
            int r2 = f(2);
            int r3 = f(3);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine();



            ///2  
            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(sta: 1, end: 1000);

            Console.WriteLine("t1 : " + t1);
            Console.WriteLine("t2 : " + t2);
            Console.WriteLine("t3 : " + t3);
            Console.WriteLine();

        }

        ///1-1
        public static int f(int x)                  ///method는 대문자가 원칙이지만 함수를 표시하기 위해 이렇게 나타냄
        {
            int y = 2 * x + 3;
            return y;
        }



        ///2-2 
        public static int Sum(int sta, int end)
        {
            int tot = 0;

            for (int k = sta; k <= end; k++)
            {
                tot += k;
            }

            return tot;
        }
















    }
}