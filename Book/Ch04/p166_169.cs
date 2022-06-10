using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p166_169
    {
        static void Main1(string[] args)
        {
            // For                                (* For 반복은 지정횟수만큼)
            // 
            // for (dataType 변수; 조건; 조건)     (* ; 필수)
            //{
            //
            //}



            // for - 덧셈                
            int a = 0;
            for (int b = 0; b <= 100; b++)
            {
                a += b;
            }
            Console.WriteLine(a);
            Console.WriteLine();


            // for - 곱셈
            long a1 = 1;                         // 0일시 뭘 곱해도 0이므로 이번엔 1로 설정.
            for (long b1 = 1; b1 <= 20; b1++)
            {
                a1 *= b1;
            }
            Console.WriteLine(a1);              //int는 표현범위 초과로 음수가 나온다.
            Console.WriteLine();


            // for - 한글
            for (int a2 = '하'; a2 <= '힣'; a2++)
            {
                Console.Write((char)a2);
            }
            Console.WriteLine();
            Console.WriteLine();


            //for - 시간을 사용한 반복문 이탈
            long a3 = DateTime.Now.Ticks;
            long count = 0;

            while (a3 + (10000000) > DateTime.Now.Ticks)
            {
                count++;

            }
            Console.WriteLine(count + "만큼 반복했습니다.");


















        }
    }
}
