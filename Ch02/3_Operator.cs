using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     날짜 : 2022/06/02
///     이름 : 최희원    
///     내용 : Operator (연산자)  (p90)
/// 
/// 
///     Operator : 변수에 저장된 데이터 처리를 위해 연산자를 사용
///                산술, 증가감소, 복합대입, 비교, 논리 연산자 등



namespace Ch02
{
    internal class _3_Operator
    {
        static void Main1(string[] args)
        {

            /// 산술 연산
            int num1 = 1;                   /// int num1 = 1, num2 = 2, num3 = 3, num4 = 4; 로 정리 가능.
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            
            int a1 = num1 + num2;
            int a2 = num1 - num2;
            int a3 = num2 * num3;
            int a4 = num4 / num2;
            int a5 = num4 % num3;          /// 나머지

            Console.WriteLine("a1 : " + a1);
            Console.WriteLine("a2 : " + a2);
            Console.WriteLine("a3 : " + a3);
            Console.WriteLine("a4 : " + a4);
            Console.WriteLine("a5 : " + a5);
            Console.WriteLine();


            /// 증가, 감소 연산
            int num = 0;

            num++;
            ++num;

            Console.WriteLine($" num : {num} ");       /// string 보간($" {0},{1}, 변수,변수 ") 출력
            Console.WriteLine();                    
                                                    
            num--;
            --num;

            Console.WriteLine($" num : {num} ");
            Console.WriteLine();


            /// 복합대입 연산
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1;                                /// n1 = n1 + 1      
            n2 -= 2;                                /// n2 = n2 - 2       
            n3 *= 3;                                /// n3 = n3 * 3      
            n4 /= 4;                                /// n4 = n4 / 4     

            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}");
            Console.WriteLine();


            /// 비교 연산
            int nb1 = 1;
            int nb2 = 2;

            bool rs1 = nb1 > nb2;          
            bool rs2 = nb1 < nb2;          
            bool rs3 = nb1 >= nb2;                 /// 크거나 같다
            bool rs4 = nb1 <= nb2;                 /// 작거나 같다
            bool rs5 = nb1 == nb2;                 /// 같다
            bool rs6 = nb1 != nb2;                 /// 다르다

            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("rs4 : " + rs4);
            Console.WriteLine("rs5 : " + rs5);
            Console.WriteLine("rs6 : " + rs6);
            Console.WriteLine();


            /// 논리 연산
            //int nb1 = 1;
            //int nb2 = 2;

            bool rst1 = nb1 > 1 && nb2 > 2;       /// && : 그리고, 교집합  
            bool rst2 = nb1 > 0 && nb2 > 1;       
            bool rst3 = nb1 > 1 || nb2 > 2;       /// || : 또는, 합집합  
            bool rst4 = nb1 > 0 || nb2 > 2;       
            bool rst5 = !(nb1 > nb2);             /// ()가 아니다

            Console.WriteLine($" rst1 : {rst1} ");
            Console.WriteLine($" rst2 : {rst2} ");
            Console.WriteLine($" rst3 : {rst3} ");
            Console.WriteLine($" rst4 : {rst4} ");
            Console.WriteLine($" rst5 : {rst5} ");
            Console.WriteLine();


            /// 조건 연산 (삼항연산)
            int a = 1;

            string result = (a > 1) ? "a는 1보다 크다" : "a는 1보다 크지 않다.";   /// Console.WriteLine(  조건  ?  true값  :  false값 );

            Console.WriteLine("result : " + result);
            Console.WriteLine();





        }




    }
}
