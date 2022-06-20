using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Exception Handling


namespace Book.Ch10
{
    internal class p468_473
    {
        static void Main1(string[] args)
        {


            /// Exception - 1) 인덱스 범위 초과
            string[] arr = { "가(0)", "나(1)" };
            Console.Write("숫자를 입력해주세요 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("입력한 위치의 값은'" + arr[a] + "'입니다");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            /// Exception Handling - Basic
            string[] arr0 = { "가", "나" };
            Console.Write("숫자를 입력해주세요 : ");
            int a0 = int.Parse(Console.ReadLine());

            if (a0 < arr0.Length)
            { Console.WriteLine("입력한 위치의 값은'" + arr0[a0] + "'입니다"); }
            else { Console.WriteLine("인덱스 범위를 넘어섰습니다"); }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            /// try, catch, finally
            ///
            ///   try     : 예외상황
            ///   catch   : 처리
            ///   finally : 예외상황 여부와 상관없이 무조건 실행
            /// 
            ///   try     : 
            ///   catch   :
            ///   
            ///   try     : 예외상황이 발생해도 그냥 넘어간다.
            ///   finally : 예외상황 여부와 상관없이 무조건 실행
            ///


            /// Exception Handling - try, catch
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
                return;                                      ///return - 종료 키워드
            }
            Console.WriteLine("프로그램 종료");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            /// Exception Handling - try, catch, finally
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
                return;                                      ///return - 종료 키워드
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }

        }
    }
}
