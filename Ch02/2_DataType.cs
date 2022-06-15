using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/02
 * 이름 :최희원
 * 내용 : Data Type(자료형)  (p83)
 * 
 * 
 * 
 * [Data Type]
 * - 변수에 저장되는 데이터의 종류와 크기를 Data Type으로 선언
 * - Data Type은 크게 기본형과 참조형으로 나뉨
 * 
 * [Data Type 종류]
 * sbyte :
 * byte : 
 * int : 4byte 정수
 * long : 8byte 정수
 * float : 4byte 실수
 * double : 8byte 실수
 * char : 문자
 * string : 문자열
 * bool : true / false 
 * 
 */

namespace Ch02
{
    internal class _2_DataType
    {
        static void Main1(string[] args)
        {
            // Integer Type (정수형)
            sbyte i1 = 127;            //1byte, 부호 있는 정수, -128 - 127
            byte i2 = 255;            //1byte, 부호 없는 정수, 0 - 255
            short i3 = 32767;          //2byte, 부호 없는 정수, -32,766 - 32,767
            int i4 = 2147483647;     //4byte, 부호 없는 정수, -2,147,483,648 - 2,127,483,647
            long i5 = 2147483648L;    //8byte, 부호 없는 정수, 교재참고

            Console.WriteLine("integer1 : {0}", i1);
            Console.WriteLine("integer2 : {0}", i2);
            Console.WriteLine("integer3 : {0}", i3);
            Console.WriteLine("integer4 : {0}", i4);
            Console.WriteLine("integer5 : {0}", i5);
            Console.WriteLine();


            // Real Number Type (실수형)
            float r1 = 1.123456789f;
            double r2 = 1.12345678901234567890;

            Console.WriteLine("realNum1 : " + r1);
            Console.WriteLine("realNum2 : " + r2);
            Console.WriteLine();


            // Logical Type (논리형)
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("b2 : " + b2);
            Console.WriteLine();


            // Character Type (문자형)
            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);
            Console.WriteLine();


            // String Type (문자열)
            string s1 = "A";
            string s2 = "가";
            string s3 = "Apple";
            string s4 = "안녕하세요";
            string s5 = "10";

            Console.WriteLine("str1 : " + s1);
            Console.WriteLine("str2 : " + s2);
            Console.WriteLine("str3 : " + s3);
            Console.WriteLine("str4 : " + s4);
            Console.WriteLine("str5 : " + s5);
            Console.WriteLine();


            // Object Type (명시적인 타입의 선언 없이도 변수를 선언하는 것이 가능)
            object o1 = 11;
            object o2 = 3.141592;
            object o3 = true;
            object o4 = 'A';
            object o5 = "Apple";

            Console.WriteLine("obj1 : " + o1);
            Console.WriteLine("obj2 : " + o2);
            Console.WriteLine("obj3 : " + o3);
            Console.WriteLine("obj4 : " + o4);
            Console.WriteLine("obj5 : " + o5);
            Console.WriteLine();


            // Var Type (명시적인 타입의 선언 없이도 변수를 선언하는 것이 가능)  
            var v1 = 11;
            var v2 = 3.141592;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("v1 : " + v1);
            Console.WriteLine("v2 : " + v2);
            Console.WriteLine("v3 : " + v3);
            Console.WriteLine("v4 : " + v4);
            Console.WriteLine("v5 : " + v5);
            Console.WriteLine();

        }






    }
}
