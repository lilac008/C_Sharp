using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Exception Handling 
/// Compile-time Error (컴파일시점 오류)
/// Systax Error (문법오류)


namespace Book.Ch10
{
    internal class p468_473
    {
        static void Main1(string[] args)
        {


            /// 기본 예외처리 - if, else
            string[] arr = { "가[0]", "나[1]" };
            Console.Write("숫자를 입력 : ");
            int a = int.Parse(Console.ReadLine());

            if (a < arr.Length)
            { Console.WriteLine("입력한 위치의 값은'" + arr[a] + "'입니다"); }
            else { Console.WriteLine("::index 범위 초과::"); }

            Console.WriteLine();
            Console.WriteLine();


            /// 고급 예외처리 - try, catch, finally
            ///
            ///   try     : 예외 상황
            ///   catch   : 처리
            ///   finally : 무조건 실행
            /// 
            ///   try     : 예외 상황
            ///   catch   : 처리
            ///   
            ///   try     : 예외 발생 (그냥 넘어간다)
            ///   finally : 무조건 실행



            ///공통
            Console.Write("입력 : ");
            string a0 = Console.ReadLine();
            int index = int.Parse(a0);
            Console.WriteLine("입력숫자 : " + index);


            /// Finally 사용하지 않음
            Console.Write("입력 : ");
            string a1 = Console.ReadLine();

            try
            {
                int b1 = int.Parse(a1);
                Console.WriteLine("입력 숫자 : " + b1);
            }
            catch (Exception e1)
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(e1.GetType());
                return;                                          /// 구문에서 벗어남                                      
            }
            Console.WriteLine("::프로그램 종료::");              ///출력되지 않는다.

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            /// Finally 사용
            Console.Write("입력 : ");
            string a2 = Console.ReadLine();

            try
            {
                int b2 = int.Parse(a2);
                Console.WriteLine("입력 숫자 : " + b2);
            }
            catch (Exception e2)
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(e2.GetType());
                return;                                      
            }
            finally
            {
                Console.WriteLine("::프로그램 종료::");
            }

        }
    }
}
