using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/02 
///     이름 : 최희원
///     내용 : Variable(변수), Constant(상수)(p79)
/// 
/// 
///     Variable : data(숫자,문자)를 처리(+,- 등 연산)하기 위해 생성되는 메모리 공간
///     
///     Constant : data를 변경할 수 없는 변수                      
///                Const dataType variableName = value; 로 선언     ex) const int a = 10;



namespace Ch02
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {

            ///Variable
            int num1;                    /// Variable 선언
            num1 = 1;                    /// 대입


            int num2 = 2;                /// Variable 선언과 초기화
            int num3 = num1 + num2; 

            Console.WriteLine("num3 : " + num3);
            Console.WriteLine();


            // Constant 
            const double p = 3.141592;
            const int a = 10;
            ///num = 20;<-- 상수는 값 변경X
            ///num = 30;

            Console.WriteLine("NUM : " + a);           
            Console.WriteLine("PI : " + p);




        }



    }
}
