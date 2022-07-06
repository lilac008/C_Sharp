using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     날짜 : 2022/06/14
///     이름 : 최희원
///     내용 : Internal Class (내장 클래스) ()
/// 



namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main1(string[] args)
        {
            /// 1. Math Class  (p215)
            ///Math math = new Math(); 가 아니다.
            Console.WriteLine("PI : " + Math.PI);
            Console.WriteLine("9  제곱근 : " + Math.Sqrt(9));
            Console.WriteLine("16 제곱근 : " + Math.Sqrt(16));
            Console.WriteLine("절대값 : " + Math.Abs(-5));
            Console.WriteLine("올림값 : " + Math.Ceiling(1.2));
            Console.WriteLine("올림값 : " + Math.Ceiling(1.8));
            Console.WriteLine("내림값 : " + Math.Floor(1.2));
            Console.WriteLine("내림값 : " + Math.Floor(1.8));
            Console.WriteLine("반올림 : " + Math.Round(1.2));
            Console.WriteLine("반올림 : " + Math.Round(1.8));
            Console.WriteLine();


            /// 2. Random Class  (p207)
            Random r = new Random();

            int rand1 = r.Next();
            int rand2 = r.Next(10);
            int rand3 = r.Next(1, 11);

            Console.WriteLine("rand1 : " + rand1);
            Console.WriteLine("rand2 : " + rand2); /// 0 ~ 9 사이의 임의의 정수
            Console.WriteLine("rand3 : " + rand3); /// 1 ~ 10 사이의 임의의 정수
            Console.WriteLine();


            double n1 = r.NextDouble();
            double n2 = n1 * 10;
            double n3 = Math.Ceiling(n2);

            Console.WriteLine("num1 : " + n1); /// 0 ~ 1 사이의 임의의 실수
            Console.WriteLine("num2 : " + n2); /// 0 ~ 10 사이의 임의의 실수
            Console.WriteLine("num3 : " + n3); /// 1 ~ 10 사이의 임의의 정수
            Console.WriteLine();



            /// 3. DateTime Class           
            /// singleton object
            DateTime d = DateTime.Now;

            Console.WriteLine("now : " + d);

            /// 개별 시간 데이터 출력
            Console.WriteLine("년 : " + d.Year);
            Console.WriteLine("월 : " + d.Month);
            Console.WriteLine("일 : " + d.Day);
            Console.WriteLine("시 : " + d.Hour);
            Console.WriteLine("분 : " + d.Minute);
            Console.WriteLine("초 : " + d.Second);

            /// 문자열 Format
            string result1 = d.ToString("yyyy-MM-dd");
            Console.WriteLine("result1 : " + result1);

            string result2 = d.ToString("yy-MM-dd hh:mm:ss");
            Console.WriteLine("result2 : " + result2);







        }
    }
}
