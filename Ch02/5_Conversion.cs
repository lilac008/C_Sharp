using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     날짜 : 2022/06/03
///     이름 : 최희원    
///     내용 : Data Type Conversion (데이터 형식 변환)  (p106)
/// 


namespace Ch02
{
    internal class _5_Conversion
    {
        static void Main1(string[] args)
        {
            /// 작은변수에서 큰변수
            byte  n1 = 255;
            short n2 = n1;
            int   n3 = n2;

            Console.WriteLine(" num1 : {0} ", n1);                  /// Var a = 1; Var b = 2;     " {0},{1} ", a, b
            Console.WriteLine(" num2 : {0} ", n2);
            Console.WriteLine(" num3 : {0} ", n3);
            Console.WriteLine();


            /// 큰변수에서 작은 변수(overflow)
            int    nb1 = 256;
            short  nb2 = (short) nb1;                /// ()안의 자료형으로 강제변환
            byte   nb3 = (byte)  nb2;        

            Console.WriteLine($" nb1 : {nb1} ");                   /// Var a = 1; Var b = 2;      $"  {a},{b}  "
            Console.WriteLine($" nb2 : {nb2} ");
            Console.WriteLine($" bn3 : {nb3} ");             
            Console.WriteLine();


            /// 정수에서 실수
            int a=1, b=2, c=3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : " + d1);
            Console.WriteLine("d2 : " + d2);
            Console.WriteLine("d3 : " + d3);
            Console.WriteLine();


            /// 실수에서 정수
            double num1 = 1.2;
            double num2 = 2.15;
            double num3 = 11.123;

            int rs1 = (int)num1;        ///double(8byte)에서 int(4byte) 강제
            int rs2 = (int)num2;
            int rs3 = (int)num3;

            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine();









        }
    }
}
