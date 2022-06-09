using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/02
 * 이름 :최희원
 * 내용 : Operator(연산자)  (p90)
 *
 *
 *
 * Operator(연산자)
 * - 변수에 저장된 데이터의 처리를 위해 Operator를 사용
 * - Operator는 크게 산술, 증가감소, 복합대입, 비교, 논리 연산자 등이 있다.
 *
 */


namespace Ch02
{
    internal class _3_Operator
    {
        static void Main1(string[] args)
        {

            // 산술 Operator
            int num1 = 1;        // int num1=1,num2=2,num3=3,num4=4;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            
            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3;         //4 나누기3 나머지

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);
            Console.WriteLine("r5 : " + r5);


            // 증가, 감소 Operator
            int num = 0;

            num++;
            ++num;

            Console.WriteLine("=======================");
            Console.WriteLine($"num : {num}"); //string 문자열 보간 출력

            num--;
            --num;

            Console.WriteLine("=======================");
            Console.WriteLine($"num : {num}");


            // 복합대입 Operator
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1;           // n1 = n1 + 1      
            n2 -= 2;           // n2 = n2 - 2       
            n3 *= 3;           // n3 = n3 * 3      
            n4 /= 4;           // n4 = n4 / 4     

            Console.WriteLine("=======================");
            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}");


            // 비교 Operator
            int cp1 = 1;
            int cp2 = 2;

            bool rs1 = cp1 > cp2;          // var1이 var2보다 크다 
            bool rs2 = cp1 < cp2;          // var1이 var2보다 작다
            bool rs3 = cp1 >= cp2;         // var1이 var2보다 크거나 같다
            bool rs4 = cp1 <= cp2;         // var1이 var2보다 작거나 같다
            bool rs5 = cp1 == cp2;         // var1이 var2과 서로 같다
            bool rs6 = cp1 != cp2;         // var1이 var2과 서로 다르다

            Console.WriteLine("=======================");
            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("rs4 : " + rs4);
            Console.WriteLine("rs5 : " + rs5);
            Console.WriteLine("rs6 : " + rs6);


            // 논리 Operator
            int cpp1 = 1;
            int cpp2 = 2;

            bool res1 = cpp1 > 1 && cpp2 > 2;    // cpp1이 1보다 크고 그리고 cpp2는 2보다 크다. f && f = f  and 연산 t, f = f / t,t = t
            bool res2 = cpp1 > 0 && cpp2 > 1;    // cpp1이 0보다 크고 그리고 cpp2는 1보다 크다.
            bool res3 = cpp1 > 1 || cpp2 > 2;    // cpp1이 1보다 크고 또는 cpp2는 2보다 크다. f || f = f    or 연산, 0,1 = 1 / 1,0 = 1, 
            bool res4 = cpp1 > 0 || cpp2 > 2;    // cpp1이 0보다 크고 또는 cpp2는 2보다 크다.
            bool res5 = !(cpp1 > cpp2);          // cpp1이 cpp2보다 크지 않다.

            Console.WriteLine("=======================");
            Console.WriteLine($"res1 : {res1}");
            Console.WriteLine($"res2 : {res2}");
            Console.WriteLine($"res3 : {res3}");
            Console.WriteLine($"res4 : {res4}");
            Console.WriteLine($"res5 : {res5}");


            // 조건 Operator
            int a = 1;

            string result = (a > 1) ? "a는 1보다 크다" : "a는 1보다 크지 않다.";   //참이면 전자, 거짓이면 후자 출력
            
            Console.WriteLine("=======================");
            Console.WriteLine("result : " + result);





        }




    }
}
