using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p142_143
    {
        static void Main1(string[] args)
        {

            // 삼항 연산 bool
            // (comparison operation(비교연산) ? true : false);
            // 
            Console.Write("2로 나누었을 때, 나머지가 0이 되는 수는? : ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(n3 % 2 == 0 ? true : false);      //- 참, 거짓 위치에 불 자료형 사용
            Console.WriteLine();

            Console.Write("짝수 또는 홀수를 입력 : ");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine(n4 % 2 == 0 ? "짝수" : "홀수");   //참, 거짓 위치에 문자열 자료형 사용
            Console.WriteLine();


            // 삼항 연산
            Console.Write("자연수의 범위 : ");
            string a5 = Console.ReadLine();
            int n5 = int.Parse(a5);

            Console.WriteLine(n5 > 0 ? "자연수입니다" : "자연수가 아닙니다");
            Console.WriteLine();
























        }
    }
}
