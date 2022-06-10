using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p158_161
    {
        static void Main1(string[] args)
        {

            // 배열 생성
            // dataType[] 변수 = {} 
            //
            int[] arri = { 52, 273, 32, 65, 103 };
            long[] arrl = { 52, 273, 32, 65, 103 };
            float[] arrf = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
            double[] arrd = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            string[] arrs = { "윤인성", "연하진", "윤아린" };


            // 배열 요소
            int[] Arr1 = { 52, 273, 32, 65, 103 };
            Arr1[0] = 0;                               //배열 요소 변경
            Console.WriteLine(Arr1[0]);                //0      ??????????
            Console.WriteLine(Arr1[1]);                //273
            Console.WriteLine(Arr1[2]);                //32
            Console.WriteLine(Arr1[3]);                //65
            Console.WriteLine();


            // 배열 구성요소 개수
            // 변수.Length
            //
            int[] Arr2 = { 52, 273, 32, 65, 103 };
            Console.WriteLine(Arr2.Length);             //배열 길이 출력, 5
            Console.WriteLine();

            //오류
            //int[] Arr3 = { 52, 273, 32, 65, 103 };
            //Console.WriteLine(Arr3[5]);              //배열범위를 벗어남
            //


            //원하는 사이즈의 배열 생성
            //int[] 변수 = new int[100];              // 기본값으로 채워짐. 숫자는 0, 문자열은 빈 문자열, 이후에 알아보는 object는 null로 초기화. 
            //
            int[] Arr4 = new int[100];

            Console.WriteLine(Arr4[0]);              //결과 0
            Console.WriteLine(Arr4[99]);             //결과 0















        }
    }
}
