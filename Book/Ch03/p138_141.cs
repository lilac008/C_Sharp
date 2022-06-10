using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p138_141
    {
        static void Main1(string[] args)
        {


            // dataType variable(변수) = 정의;
            // Switch {  case0:                             //고정된 값을 비교할때는 Switch를 쓴다.
            //               
            //                 break;                       //break를 감싸는 조건문을 벗어난다.
            //
            //           default:
            //         }


            //홀,짝수
            Console.Write("숫자를 입력하세요: ");
            int a = int.Parse(Console.ReadLine());        //입력값을 변수a로 정의

            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;                               //break를 감싸는 조건문을 벗어난다.
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
            Console.WriteLine();



            //break; 를 사용하지 않는 Switch 구문 
            Console.Write("이번 달은 몇 월인가요: ");
            int a2 = int.Parse(Console.ReadLine());       //입력값을 변수a2로 정의

            switch (a2)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어느 행성에 살고 계신가요?");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();





















        }
    }
}
