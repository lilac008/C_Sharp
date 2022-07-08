using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  날짜 : 2022/06/20 
///  이름 : 최희원
///  내용 : Try Catch Finally (예외처리 문) (p497)   
///   



namespace Ch08
{
    internal class _1_TryCatch
    {
        class Apple
        {
            public void Show()
            {
                Console.WriteLine("사과");
            }
        }

        static void Main1(string[] args)
        {

            ///  try-catch  :  

            ///int n1 = 1;
            ///int n2 = 0;                  /// 0으로 나눌경우, 변수 rs4에서 오류.

            ///int rs1 = n1 + n2;
            ///int rs2 = n1 - n2;
            ///int rs3 = n1 - n2;
            ///int rs4 = n1 / n2;         

            ///Console.WriteLine(rs1);
            ///Console.WriteLine(rs2);
            ///Console.WriteLine(rs3);
            ///Console.WriteLine(rs4);
            ///Console.WriteLine();


            int n1 = 1;
            int n2 = 0;
            int rs1 = 0, rs2 = 0, rs3 = 0, rs4 = 0;    ///변수를 dataType rs1; rs2; 랑 둘때의 차이점?

            try
            {
                rs1 = n1 + n2;
                rs2 = n1 - n2;
                rs3 = n1 * n2;
                rs4 = n1 / n2;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.WriteLine(rs1);
            Console.WriteLine(rs2);
            Console.WriteLine(rs3);
            Console.WriteLine(rs4);
            Console.WriteLine();




            ///  try-catch  :  배열의 index 범위를 벗어났을 때
            int[] arr = { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + "");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine();




            ///   try-catch  :  Null Point Error 

            ///Apple a1 = new Apple();
            ///a1.Show();

            ///Apple a2;                      -   선언만 하면 null값을 갖는다.
            ///a2.Show();                     -   null값은 show() method에서 오류가 난다.

            Apple a1 = new Apple();
            Apple a2 = null;

            try
            {
                a1.Show();
                a2.Show();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }




            /// try-catch-finally 
            try
            { Console.WriteLine("try..."); }
            catch
            { Console.WriteLine("catch..."); }
            finally
            { Console.WriteLine("finally..."); }
            Console.WriteLine();

            ///        try     : 예외발생 가능성이 있는 코드
            ///        cathch  : 예외 처리 코드
            ///        finally : 예외발생 여부와 상관없이 무조건 처리해야할 코드

        }






    }
}
