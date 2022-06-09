using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p90_92
    {
        static void Main1(string[] args)
        {
            //복합 연산자 : 사칙연산(+,-,*,/)자와 = 연산자를 함께 사용

            //숫자와 관련된 복합 대입 연산자
            int a = 0;
            a += 52;          // a = (0+52)
            a += 273;         // a = (0+52)+273
            a += 103;         // a = {(0+52)+273}+103 = 428
            Console.WriteLine(a);
            Console.WriteLine();

            //풀어쓰기
            int aa = 0;
            aa = aa + 52;
            aa = aa + 273;
            aa = aa + 103;

            Console.WriteLine(aa);
            Console.WriteLine();


            //문자열과 관련된 복합 대입 연산자
            string b = "hello ";
            b += "world ";
            b += "!";

            Console.WriteLine(b);
            Console.WriteLine();

            //풀어쓰기
            string bb = "hello ";
            bb = bb + "world ";
            bb = bb + "!";

            Console.WriteLine(bb);
            Console.WriteLine();

        }

    }
}
