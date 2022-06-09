using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022/06/07
 * 이름 : 최희원
 * 내용 : 반복문 While 실습하기 (p162)
 *  
 * 
 */




namespace Ch03
{
    internal class _4_While
    {
        static void Main1(string[] args)
        {
            // while
            int sum = 0;
            int a = 1;

            while (a <= 10)
            {
                sum += a;
                a++;

            }
            Console.WriteLine("1부터 10까지 합 : " + sum);
            Console.WriteLine();


            // do ~ while : 최초 1번은 무조건 반복 실행하는 반복
            int total = 0;
            int b = 1;

            do
            {
                if (b % 2 == 0)
                {
                    total += b;
                }
                b++;
            }
            while (b <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : " + total);
            Console.WriteLine();


            // break
            int c = 1;

            while (true)
            {
                if (c % 5 == 0 && c % 7 == 0)
                {
                    break;    //반복 종료
                }
                c++;
            }
            Console.WriteLine("5와 7의 최소공배수 : " + c);
            Console.WriteLine();


            // continue
            int d = 0;
            int e = 0;

            while (e <= 10)
            {
                e++;
                if (e % 2 == 1)
                {
                    continue; // 반복문 처음으로 이동

                }

                d += e;

            }
            Console.WriteLine("1부터 10까지 짝수합 : " + d);
            Console.WriteLine();












        }
    }
}
