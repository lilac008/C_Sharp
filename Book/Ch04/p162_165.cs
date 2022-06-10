using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p162_165
    {
        static void Main1(string[] args)
        {


            // while 무한반복 (* 무한 출력 방지를 위해 반드시 거짓 문장이 포함되어야. )
            //                 (* w 소문자 !!!!!!!!!!!!)



            // 무한 출력
            //
            //while (true)                       //조건이 참일경우 무한반복, 거짓일 경우 실행x
            //{
            //    Console.Write("!");            //무한히 출력.
            //}


            // ex
            int a = 0;
            int[] Arr = { 52, 273, 32, 65, 103 };

            while (a < Arr.Length)
            {
                Console.WriteLine(a + "번째 출력 : " + Arr[a]);

                a++;              //탈출 변수 
            }


            // do while                     //do : 참,거짓의 여부와 상관없이 최소 한번은 무조건 실행.
            //
            //  dataType 변수;
            //  do                           
            //  {
            //         bool 표현식이 참일동안 실행 
            //  }
            //  while(bool 표현식);



            string a1;

            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료) : ");
                a1 = Console.ReadLine();

            }
            while (a1 != "종료");














        }
    }
}
