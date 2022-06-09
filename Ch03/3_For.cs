using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022/06/07
 * 이름 : 최희원
 * 내용 : 반복문 For (P157) 
 * 
 * 
 */

namespace Ch03
{
    internal class _3_For
    {
        static void Main1(string[] args)
        {

            // For (반복)
            for (int a = 1; a <= 5; a++)
            {
                Console.WriteLine("{0}회 반복...", a);

            }
            Console.WriteLine();


            // 1~10 합
            int sum1 = 0;

            for (int b = 1; b <= 10; b++)
            {
                sum1 += b;              //sum1 = sum1 + b;
            }
            Console.WriteLine("1부터 10까지 합 : " + sum1);
            Console.WriteLine();


            // 1~10 짝수합
            int sum2 = 0;

            for (int c = 1; c <= 10; c++)
            {
                if (c % 2 == 0)          //
                {
                    sum2 += c;
                }
            }

            Console.WriteLine("1부터 10까지 짝수합 : " + sum2);
            Console.WriteLine();


            // For 중첩 (반복 중첩, thread라고 함)

            for (int aa = 1; aa <= 3; aa++)
            {
                Console.WriteLine("A : " + aa);

                for (int bb = 1; bb <= 4; bb++)
                {
                    Console.WriteLine("B : " + bb);

                    for (int cc = 1; cc <= 5; cc++)
                    {
                        Console.WriteLine("C : " + cc);
                    }
                }
            }
            Console.WriteLine();


            //구구단

            for (int e = 1; e <= 9; e++)
            {
                Console.WriteLine("{0}단 시작", e);

                for (int f = 1; f <= 9; f++)
                {
                    int g = e * f;
                    Console.WriteLine("{0} x {1} = {2}", e, f, g);
                }
            }
            Console.WriteLine();


            // 별삼각형
            for (int aa = 1; aa <= 10; aa++)
            {
                for (int bb = 1; aa >= bb; bb++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            // 역별삼각형
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 10; a <= b; b--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();


  





        }
    }
}
