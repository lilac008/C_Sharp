using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022/06/07
 * 이름 : 최희원
 * 내용 : Method   (p265)
 * 
 *  
 *  method는 대문자가 원칙
 * 
 */


namespace Ch04
{
    internal class _1_Method
    {
        /// Method 정의1
        public static int f(int x)
        {
            int y = 2 * x + 3;
            return y;
        }

        /// Method 정의2 (Method 식별 대문자)
        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }

            return total;
        }

        static void Main1(string[] args)
        {
            /// Method 정의1 호출   F11눌러서 흐름 확인하기
            int r1 = f(1);
            int r2 = f(2);
            int r3 = f(3);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);


            /// Method 정의2 호출 (Method 식별을 위해 대문자)
            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start: 1, end: 1000);

            Console.WriteLine("t1 : " + t1);
            Console.WriteLine("t2 : " + t2);
            Console.WriteLine("t3 : " + t3);

        }












    }
}