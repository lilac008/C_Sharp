using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p181_191
    {
        static void Main1(string[] args)
        {
            // 문자열 대문자화, 소문자화
            /// 변수.ToUpper() - 대문자화
            /// 변수.ToLower() - 소문자화

            string a = "Potato Tomato";
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine();

            ///의미없는 방식(method)
            string a1 = "Coca Cola";
            a1.ToUpper();                     //meaningless, non - destructive method
            Console.WriteLine(a1);
            Console.WriteLine();



            //변수.Split - 문자열 자르기
            string a2 = "감자 고구마 토마토";
            string[] arr = a2.Split(new char[] { ' ' });  //문자열 매개변수? string[] arr = a2.Split(new string[]{ " " }), StringSplitOptions.RemoveEmptyEntries); 도 가능

            foreach (var b2 in arr)
            {
                Console.WriteLine(b2);

            }
            Console.WriteLine();



            //변수.Trim() - 문자열 공백 제거

            string arr2 = "test        \n";
            Console.WriteLine("::" + arr2.Trim() + "::");
            Console.Read();
            Console.WriteLine();



            //배열을 문자열로 p185
            string[] arr3 = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", arr3));
            Console.WriteLine();


            // 이동하는 달팽이 
            ///Console.SetCursorPosition() - 콘솔 화면의 특정한 위치로 커서 이동
            ///Thread.Sleep() - 특정시간만큼 스레드 정지
            ///Console.Clear() - 콘솔 화면 지움

            ///
            Console.Write("Method 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("Method 호출 후");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            ///
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);                            //1초 간격으로 일시정지 후 출력.
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
            Console.WriteLine();
            Console.WriteLine();


            /// 
            int a3 = 1;
            while (a3 < 50)
            {
                Console.Clear();                   // 화면 지우기
                Console.SetCursorPosition(a3, 5);    // 커서 이동

                if (a3 % 3 == 0)
                    Console.WriteLine(" __@");
                else if (a3 % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);                 //100밀리초 정지
                a3++;                               //x 증가
            }


            // (p188 - 190 참고)
            //
            bool state = true;                         //switch문, while문에서 모두 벗어남
            while (state)
            {
                ConsoleKeyInfo a4 = Console.ReadKey();
                switch (a4.Key)                       //대문자 Key
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위");
                        break;

                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽");
                        break;

                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래");
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽");
                        break;
                    case ConsoleKey.X:                 //switch문, while문에서 모두 벗어남
                        state = false;
                        break;

                }
            }
            Console.WriteLine();



            //혼동 피하기

            int a5 = 10;
            while ((a5--) > 0) { Console.WriteLine(a5); }   //a5 --> 로 보이는 걸 방지하기 위해 ()







        }
    }
}
