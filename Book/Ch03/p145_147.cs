using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p145_147
    {
        static void Main1(string[] args)
        {

            //변수.Contains(); - 입력값에 대한 조건 분할 메서드

            Console.Write("입력: ");
            String a = Console.ReadLine();
            Console.WriteLine();
            if (a.Contains("안녕"))                        //Contains 커서 - bool 형식, ()안에 포함되면 무조건 참이므로 안녕이 들어가는 모든 글자가 다음 결과 값이 도출.
            { Console.WriteLine("안녕하세요...!"); }
            else
            {
                Console.WriteLine();
                Console.WriteLine("^^");
            }
            Console.WriteLine();


            // p146~147  ?????????
            //ConsoleKeyInfo a = Console.ReadKey();
            //a.char


            //            
            Console.Write("방향 키를 입력 : ");
            Console.WriteLine();

            ConsoleKeyInfo a1 = Console.ReadKey();
            Console.WriteLine();

            switch (a1.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;

                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;

                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;

                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;

                default:
                    Console.WriteLine("다른 키를 눌렀습니다.");
                    break;
            }
            Console.WriteLine();



















        }
    }
}
