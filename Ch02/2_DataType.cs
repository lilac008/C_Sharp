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
            sbyte integer1 = 127;            //1byte, 부호 있는 정수, -128 - 127
            byte integer2 = 255;            //1byte, 부호 없는 정수, 0 - 255
            short integer3 = 32767;          //2byte, 부호 없는 정수, -32,766 - 32,767
            int integer4 = 2147483647;     //4byte, 부호 없는 정수, -2,147,483,648 - 2,127,483,647
            long integer5 = 2147483648L;    //8byte, 부호 없는 정수, 교재참고

            Console.WriteLine("integer1 : {0}", integer1);
            Console.WriteLine("integer2 : {0}", integer2);
            Console.WriteLine("integer3 : {0}", integer3);
            Console.WriteLine("integer4 : {0}", integer4);
            Console.WriteLine("integer5 : {0}", integer5);

            // Real Number Type (실수형)
            float realNum1 = 1.123456789f;
            double realNum2 = 1.12345678901234567890;

            Console.WriteLine("=======================");
            Console.WriteLine("realNum1 : " + realNum1);
            Console.WriteLine("realNum2 : " + realNum2);

            // Logical Type (논리형)
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("=======================");
            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("b2 : " + b2);


            // Character Type (문자형)
            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("=======================");
            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("c2 : " + c2);


            // String Type (문자열)
            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요";
            string str5 = "10";

            Console.WriteLine("=======================");
            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine("str4 : " + str4);
            Console.WriteLine("str5 : " + str5);


            // Object Type (명시적인 타입의 선언 없이도 변수를 선언하는 것이 가능)
            object obj1 = 11;
            object obj2 = 3.141592;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("=======================");
            Console.WriteLine("obj1 : " + obj1);
            Console.WriteLine("obj2 : " + obj2);
            Console.WriteLine("obj3 : " + obj3);
            Console.WriteLine("obj4 : " + obj4);
            Console.WriteLine("obj5 : " + obj5);

            // Var Type (명시적인 타입의 선언 없이도 변수를 선언하는 것이 가능)  
            var v1 = 11;
            var v2 = 3.141592;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("=======================");
            Console.WriteLine("v1 : " + v1);
            Console.WriteLine("v2 : " + v2);
            Console.WriteLine("v3 : " + v3);
            Console.WriteLine("v4 : " + v4);
            Console.WriteLine("v5 : " + v5);


        }






    }
}
