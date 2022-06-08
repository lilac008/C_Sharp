using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 날짜 : 2022/06/02 
 * 이름 : 최희원
 * 내용 : C# 변수 실습하기 (p79)
 * 
 * 1. Variable (변수)
 *  - 데이터(숫자,문자)를 처리(+,- 등 연산)하기 위해 생성되는 메모리 공간
 *  - 여러번 데이터를 변경할 수 있음
 *  
 * 2. Constant (상수)
 *  - 데이터를 변경할 수 없는 변수
 *  - Const dataType dataname = 해당값;
 *  
 *  
 */

namespace Ch02
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {

            // Variable (변수)
            int num1;                // 선언
            num1 = 1;                // 대입


            int num2 = 2;            // 선언과 초기화
            int num3 = num1 + num2; 

            Console.WriteLine("num3 : " + num3);      //결과



            // Constant (상수)
            const double P = 3.141592;
            const int N = 10;
            //num = 20;<-- 상수는 값 변경X
            //num = 30;

            Console.WriteLine("NUM : " + N);           //결과 
            Console.WriteLine("PI : " + P);            //결과





        }



    }
}
