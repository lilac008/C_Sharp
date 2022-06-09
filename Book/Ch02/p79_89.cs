using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 1. 한 페이지내에 동일 이름의 변수를 중복 사용할 수 없다.
 *   int a = 1        (한 페이지내에 변수 a를 int 1로 먼저 지정했을 경우)
 *   long a = 1       (X)
 *   float a = 1.0    (X)
 *   double a = 1.0   (X)
 *   char a = 'a'     (X)
 *   bool a = "False" (X) 
 *   int a = 2        (X)
 *   
 * 
 * 
 * 
 *  [Chapter 02]
 *                     
 *  1. Variable (변수)
 * - 데이터(숫자,문자)를 처리(+,- 등 연산)하기 위해 생성되는 메모리 공간
 * - 여러번 데이터를 변경할 수 있음
 *  
 *  2. Constant (상수)
 *  - 데이터를 변경할 수 없는 변수
 *  - Const dataType dataname = 해당값;
 * 
 * 
 */



namespace Book.Ch02
{
    internal class p79_89
    {
        static void Main1(string[] args)
        {
            //변수로 정수 지정
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine();

            //overflow (1)
            int a2 = 2147483640;
            int b2 = 52273;

            Console.WriteLine(a2 + b2);
            Console.WriteLine();

            //overflow (2)
            int a3 = 2000000000;
            int b3 = 1000000000;
            Console.WriteLine(a3 + b3);
            Console.WriteLine();

            // overflow 해결방법 p82



            //1) unsigned 자료형 (부호가 없는 자료형)
            Console.WriteLine("------------------------");
            uint u1 = 4147483647;
            ulong u2 = 11223372036854775808;

            Console.WriteLine(u1);
            Console.WriteLine(u2);
            Console.WriteLine();

            //2) int 자료형의 최댓값과 최솟값
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine();

            //3) long 자료형의 최댓값과 최솟값
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine();
            Console.WriteLine("------------------------");


            //실수 자료형(Data Type - Real number : float, double) (p84)
            double a4 = 52.273;
            double b4 = 103.32;

            Console.WriteLine(a4 + b4);
            Console.WriteLine(a4 - b4);
            Console.WriteLine(a4 * b4);
            Console.WriteLine(a4 / b4);
            Console.WriteLine();

            //문자 자료형(Data Type - Character) (p85)
            char a5 = 'a';
            Console.WriteLine(a5);
            Console.WriteLine();

            //각 자료형의 크기 (Size of Data Type)
            //sizeof(DataType) 
            Console.WriteLine("int: " + sizeof(int) + " byte");
            Console.WriteLine("long: " + sizeof(long) + " byte");
            Console.WriteLine("float : "+ sizeof(float) + " byte");
            Console.WriteLine("double : "+ sizeof(double) + " byte");
            Console.WriteLine("char : "+ sizeof(char) + " byte");
            ////Console.WriteLine("String : " + sizeof(string) + "byte"); 는 안된다. (p88)
            Console.WriteLine("bool : "+ sizeof(bool) + " byte");
            Console.WriteLine();

            //문자 자료형 사칙연산
            char a6 = 'a';
            char b6 = 'b';

            Console.WriteLine(a6 + b6);
            Console.WriteLine(a6 - b6);
            Console.WriteLine(a6 * b6);
            Console.WriteLine(a6 / b6);
            Console.WriteLine(a6 % b6);
            Console.WriteLine();

            //문자열 자료형(Data Type - String) (p87)
            string a7 = "안녕하세요";

            Console.WriteLine(a7 + "!");
            Console.WriteLine(a7[0]);
            Console.WriteLine(a7[1]);
            Console.WriteLine(a7[2]);
            Console.WriteLine();

            /*문자열 자료형의 크기 (p88)
             * 
             *  int - struct System.Int32
             *  long - struct System.Int62
             *  float - struct System.single
             *  double - struct System.double
             *  char - struct System.char
             * 
             *  string - class System.String
             * 
             *  따라서 Console.WriteLine("String : " + sizeof(string) + "byte"); 는 성립되지 않는다.
             * 
             */

            //bool 자료형
            bool o1 = 10 < 0;
            bool o2 = 20 > 100;

            Console.WriteLine(o1);
            Console.WriteLine(o2);














        }
    }
}
