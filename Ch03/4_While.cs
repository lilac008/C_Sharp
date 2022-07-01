using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : While 무한반복문  (p162)
/// 


namespace Ch03
{
    internal class _4_While
    {
        static void Main1(string[] args)
        {

            /// while
            int tot = 0;
            int a = 1;

            while (a <= 10)
            {
                tot += a;
                a++;
            }
            Console.WriteLine("1부터 10까지 합 : " + tot);
            Console.WriteLine();



            /// do ~ while :  최초 1번은 무조건 실행하는 반복
            int tota = 0;
            int b = 1;

            do
            {
                if (b % 2 == 0) { tota += b; }
                b++;
            }
            while (b <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : " + tota);
            Console.WriteLine();



            /// break : 현재 반복문 탈출
            int c = 1;

            while (true)
            {
                if (c % 5 == 0 && c % 7 == 0) { break; }            /// 반복문 종료
                c++;
            }
            Console.WriteLine("5와 7의 최소공배수 : " + c);
            Console.WriteLine();



            /// continue : 현재 반복문 탈출해서 계속
            int total = 0;
            int d = 0;

            while (d <= 10)
            {
                d++;
                if (d % 2 == 1) { continue; }                       ///반복문 처음으로 이동
                total += d;
            }
            Console.WriteLine("1부터 10까지 짝수합 : " + total);
            Console.WriteLine();












        }
    }
}
