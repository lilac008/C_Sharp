using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p62_78
    {
        static void Main1(string[] args)
        {
            //출력
            Console.WriteLine("Hello C# programming .. !");
            Console.WriteLine();

            ////////기본자료형 p63
            //정수
            Console.WriteLine(52);
            Console.WriteLine();

            //덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine();

            //연산 우선순위
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine();

            // % 나머지 연산
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);
            Console.WriteLine();

            //정수의 연산
            Console.WriteLine("---------------------");
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);
            Console.WriteLine();

            //음수, % 나머지 연산 (* 혼동을 피하려면 두 가지 모두 양수로 변환해서 사용해야 한다.)
            Console.WriteLine(4 % 3);        //1
            Console.WriteLine(-4 % 3);       //-1
            Console.WriteLine(4 % -3);       //1
            Console.WriteLine(-4 % -3);      //-1
            Console.WriteLine();

            //실수 p67
            Console.WriteLine("---------------------");
            Console.WriteLine(52.273);
            Console.WriteLine();

            //정수, 실수
            Console.WriteLine(0);           // 정수
            Console.WriteLine(0.0);         // 실수
            Console.WriteLine();

            //실수의 사칙연산
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine();

            // 실수의 % 나머지 연산  (* 주의!) 
            Console.WriteLine(5.0 % 2.2);     //교재에는 0.6, 여기서는 0.599999...
            Console.WriteLine();

            //문자
            Console.WriteLine("---------------------");
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');
            Console.WriteLine();

            //문자열
            Console.WriteLine("안녕하세요");
            Console.WriteLine();

            //escape(이스케이프 문자, 탈출 문자)
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("\"");
            Console.WriteLine();

            //+ 연결 연산자
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
            Console.WriteLine();

            //문자열 선택
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine();

            //예외 (* ctrl + F5 = 릴리즈 모드)
            //Console.WriteLine("안녕하세요"[100]);
            Console.WriteLine();

            //문자 덧셈
            Console.WriteLine('가' + '힣');   //가 = 44032, 힣=55203,  
            Console.WriteLine();

            //bool
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine();

            //bool과 비교 연산
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);
            Console.WriteLine();

            //! 부정 연산
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
            Console.WriteLine();

            //bool과 논리 연산   (p78)
            // || 논리합 (shift + w)
            // && 논리곱
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            Console.WriteLine();









        }
    }
}
