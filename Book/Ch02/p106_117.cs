using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p106_117
    {
        static void Main(string[] args)
        {



            //강제 자료형 변환 - 오류
            //long a = 2147483647L + 2147483647L;
            //int b = a;
            //Console.WriteLine(b);

            //강제 변환
            var n1 = (int)10.0;
            var n2 = (float)10;
            var n3 = (double)10;

            //강제 변환 - 데이터 손실
            long a1 = 2147483647L + 2147483647L;
            int b1 = (int)a1;
            Console.WriteLine(b1);
            Console.WriteLine();

            //강제 변환 - 데이터 손실 미발생
            long a2 = 52273;
            int b2 = (int)a2;
            Console.WriteLine(b2);
            Console.WriteLine();
            Console.WriteLine("----------------------");


            /* 자동 자료형 변환
             * 
             * long - float, double
             * int - long, float, double
             * float - double
             * char - int, long, float, double 
             * 
             */

            //자동 변환 - 숫자손상
            long a3 = 2147483647L + 2147483647L;
            int b3 = (int)a3;
            Console.WriteLine(b3);
            Console.WriteLine();

            //자동 변환 - 숫자 손상 (실수)
            double a4 = 52.27310331;
            int b4 = (int)a4;
            Console.WriteLine(b4);
            Console.WriteLine();

            //자동 변환
            int a5 = 2147483647;
            long b5 = a5;               //int를 long으로
            Console.WriteLine(b5);

            double c5 = a5;             //int를 double로
            Console.WriteLine(c5);
            Console.WriteLine();
            Console.WriteLine("----------------------");


            //오류) 문자열을 숫자로 변환 
            //string a6 = "52273";
            //int b6 = (int)a6;
            //Console.WriteLine(b6);


            /* dataType.Parse("문자") - 문자열을 기본 자료형으로
             * 
             * int.Parse() : 다른 자료형을 int 자료형으로
             * long.Parse() : 다른 자료형을 long 자료형으로
             * float.Parse() : 다른 자료형을 float 자료형으로
             * double.Parse() : 다른 자료형을 double 자료형으로
             */

            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));


            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());
            Console.WriteLine();

            //오류 - 숫자로 변환 불가
            //Console.WriteLine(int.Parse("52.273"));    // 실수의 자료유형이 안맞음. 
            //Console.WriteLine(int.Parse("abc"));
            Console.WriteLine("--------------------------------");


            // ().ToString() 다른 자료형을 문자열로 변환

            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType);
            Console.WriteLine((52.273).ToString().GetType);
            Console.WriteLine(('a').ToString().GetType);
            Console.WriteLine((true).ToString().GetType);
            Console.WriteLine((false).ToString().GetType);
            Console.WriteLine();

            //().ToString() 소수점 제거
            double n4 = 52.273103;
            Console.WriteLine(n4.ToString("0.0"));
            Console.WriteLine(n4.ToString("0.00"));
            Console.WriteLine(n4.ToString("0.000"));
            Console.WriteLine(n4.ToString("0.0000"));
            Console.WriteLine();
            Console.WriteLine("------------------------");

            //숫자 + 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
            Console.WriteLine();
            Console.WriteLine("------------------------");

            //문자열 변환 - 다른 방법 
            int n5 = 52273;
            string o5 = n5 + "";
            Console.WriteLine(o5);
            Console.WriteLine();

            //문자열 변환 오류의 예
            //char n6 = 'a';        
            //string o6 = n6 + "";
            //Console.WriteLine();


            //bool.Parse()로 문자열 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));
            Console.WriteLine();

            //int(-2147483648 ~ 0 ~ 2147483647) 최솟값의 음수
            int n7 = int.MinValue;
            Console.WriteLine(-n7); //int 최솟값에는 대응되는 양수가 없어 음수를 집어넣어도 그대로 출력된다.
            //Console.WriteLine(-(-2147483648));  위는 오류가 없지만, 이렇게 하면 오류가 발생
















        }
    }
}
