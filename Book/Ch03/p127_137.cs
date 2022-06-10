using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p127_137
    {
        static void Main1(string[] args)
        {
            // If

            //홀,짝수
            Console.WriteLine("숫자입력 : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            { Console.WriteLine("짝수입니다!"); }

            if (a % 2 == 1)
            { Console.WriteLine("홀수입니다!"); }
            Console.WriteLine();

            //현재 시간
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine();

            //오전, 오후
            if (DateTime.Now.Hour < 12)
            { Console.WriteLine("오전입니다"); }

            if (12 <= DateTime.Now.Hour)
            { Console.WriteLine("오후입니다"); }
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            // If else

            //홀,짝수
            Console.WriteLine("숫자입력 : ");
            int a1 = int.Parse(Console.ReadLine());

            if (a1 % 2 == 0)
            { Console.WriteLine("짝수입니다!"); }
            else
            { Console.WriteLine("홀수입니다!"); }
            Console.WriteLine();


            //오전과 오후 구분
            if (DateTime.Now.Hour < 12)
            { Console.WriteLine("오전입니다."); }
            else
            { Console.WriteLine("오후입니다"); }
            Console.WriteLine("------------------------------");
            Console.WriteLine();



            //If else 중첩 

            if (DateTime.Now.Hour < 11)
            { Console.WriteLine("아침 먹을 시간입니다."); }

            else
            {
                if (DateTime.Now.Hour < 15)
                    Console.WriteLine("점심 먹을 시간입니다.");
                else { Console.WriteLine("저녁 먹을 시간입니다."); }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();



            //If   else if    else

            //
            if (DateTime.Now.Hour < 11)
            { Console.WriteLine("아침 먹을 시간입니다."); }

            else if (DateTime.Now.Hour < 15)
            { Console.WriteLine("점심 먹을 시간입니다"); }

            else
            { Console.WriteLine("저녁 먹을 시간입니다"); }
            Console.WriteLine();



            //범위 연산의 오류
            double g1 = 2.0;
            //if (0.4 < g1 < 4.5){ }      // 오류


            //범위 연산
            double g2 = 3.6;

            if (g2 == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= g2 && g2 < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= g2 && g2 < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= g2 && g2 < 3.5)
                Console.WriteLine("일반인");
            else if (2.3 <= g2 && g2 < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= g2 && g2 < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= g2 && g2 < 1.74)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= g2 && g2 < 1.0)
                Console.WriteLine("자벌레");
            else if (0 <= g2 && g2 < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
            Console.WriteLine();


            //범위 연산 간단 사용
            double g3 = 3.6;   // 학점변수

            if (g3 == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= g3)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= g3)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= g3)
                Console.WriteLine("일반인");
            else if (2.3 <= g3)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= g3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= g3)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= g3)
                Console.WriteLine("자벌레");
            else if (0 <= g3)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
            Console.WriteLine();













        }
    }
}
