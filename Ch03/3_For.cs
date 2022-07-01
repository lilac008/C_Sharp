using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : For 반복문, Thread 반복문(For 반복문 중첩)  (p157)
/// 
/// 


namespace Ch03
{
    internal class _3_For
    {
        static void Main1(string[] args)
        {

            /// For
            for (int a = 1; a <= 5; a++)
            {
                Console.WriteLine("{0}회 반복...", a);
            }
            Console.WriteLine();


            /// For - 합
            int sum1 = 0;

            for (int b = 1; b <= 10; b++)
            {
                sum1 += b;                                    ///sum1 = sum1 + b;
            }
            Console.WriteLine("1부터 10까지 합 : " + sum1);
            Console.WriteLine();


            /// For - 짝수합
            int sum2 = 0;

            for (int c = 1; c <= 10; c++)
            {
                if (c % 2 == 0)                          
                {
                    sum2 += c;
                }
            }
            Console.WriteLine("1부터 10까지 짝수합 : " + sum2);
            Console.WriteLine();


            /// Thread (반복문 중첩)
            for (int d = 1; d <= 3; d++)
            {
                Console.WriteLine("A : " + d);

                for (int e = 1; e <= 4; e++)
                {
                    Console.WriteLine("B : " + e);

                    for (int f = 1; f <= 5; f++)
                    {
                        Console.WriteLine("C : " + f);
                    }
                }
            }
            Console.WriteLine();


            /// Thread - 구구단
            for (int g = 2; g <= 9; g++)
            {
                Console.WriteLine("{0}단 시작", g);                        /// Console.WriteLine();

                for (int h = 1; h <= 9; h++)
                {
                    int i = g * h;
                    Console.WriteLine("{0} x {1} = {2}", g, h, i);
                }
            }
            Console.WriteLine();


            /// Thread - 별삼각형
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; j >= k; k++)                                /// j <= k; 이면 무한출력
                {
                    Console.Write("*");                                     /// Console.Write(); 
                }
                Console.WriteLine();                                        /// Console.WriteLine();
            }
            Console.WriteLine();



            /// Thread - 역별삼각형
            for (int m=1; m <= 10; m++)
            {
                for (int p=10; m <= p; p--)                                /// m <= p; 이면 무한출력
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();






        }
    }
}
