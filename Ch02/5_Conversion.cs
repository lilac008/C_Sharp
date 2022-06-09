using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/03
 * 이름 : 최희원
 * 내용 : 데이터 형식 변환  (p106)
 * 
 * 
 */

namespace Ch02
{
    internal class _5_Conversion
    {
        static void Main1(string[] args)
        {
            //작은변수에서 큰변수
            byte  num1 = 255;
            short num2 = num1;
            int   num3 = num2;

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine("=======================");


            //큰변수에서 작은 변수(overflow)
            int    var1 = 256;
            short  var2 = (short) var1;       // 강제 (short)
            byte   var3 = (byte) var2;        // 강제 (byte)

            Console.WriteLine($"var1 : {var1}");
            Console.WriteLine($"var2 : {var2}");
            Console.WriteLine($"var3 : {var3}");             //????????
            Console.WriteLine("=======================");


            //정수에서 실수
            int a=1, b=2, c=3;

            double d1 = a;
            double d2 = b;
            double d3 = c;

            Console.WriteLine("d1 : " + d1);
            Console.WriteLine("d2 : " + d2);
            Console.WriteLine("d3 : " + d3);
            Console.WriteLine("=======================");


            //실수에서 정수
            double n1 = 1.2;
            double n2 = 2.15;
            double n3 = 11.123;

            int rs1 = (int)n1;        //double(8byte)에서 int(4byte) 강제
            int rs2 = (int)n2;
            int rs3 = (int)n3;

            Console.WriteLine("rs1 : " + rs1);
            Console.WriteLine("rs2 : " + rs2);
            Console.WriteLine("rs3 : " + rs3);
            Console.WriteLine("=======================");









        }
    }
}
