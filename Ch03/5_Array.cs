using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : Array (배열)  (p157)
///
///
///       자료형[] 변수 = {   ,  ,  ,  ,  ,   }; 
///       
///       자료형[] 변수 = new 자료형[배열 개수];
///       변수[0] = 값;
///       


namespace Ch03
{
    internal class _5_Array
    {
        static void Main1(string[] args)
        {

            /// Array 선언
            int[] arr = new int[3];                        /// 선언 (null값)
            
            arr[0] = 10;                                   /// 초기화 (초깃값 할당)
            arr[1] = 20;
            arr[2] = 30;

            for (int i = 0; i < 3; i++)         
            {
                Console.WriteLine(" arr {0}번째 데이터 : {1} ", i + 1, arr[i]);
            }
            Console.WriteLine();


            /// Array 생성
            int[]     nums  = { 1, 2, 3, 4, 5 };            /// 생성(선언+초기화)
            char[]    chars = { 'A', 'B', 'C' };
            string[] cities = { "서울", "대전", "대구", "부산", "광주" };


            /// Array 길이 - 변수.Length
            Console.WriteLine("nums 길이 : " + nums.Length);
            Console.WriteLine("chars 길이 : " + chars.Length);
            Console.WriteLine("cities 길이 : " + cities.Length);
            Console.WriteLine();


            /// Array 반복문
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            foreach (char c in chars)
            {
                Console.Write(c + "  ");
            }
            Console.WriteLine();


            foreach (string city in cities)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();




            /// [다차원 배열]
            /// 1차원 배열
            int[] arr1 = { 10, 20, 30, 40, 50, 60 };
            int total = 0;

            foreach (int n1 in arr1)
            {
                total += n1;

            }
            Console.WriteLine("arrd1 총합 : " + total);
            Console.WriteLine();


            /// 2차원 배열(Matrix 행렬)
            int[,] arr2 = { { 1, 2, 3, 4 },
                             { 5, 6, 7, 8 },
                             { 9, 10, 11, 12} };

            Console.WriteLine("arr2[0,0] : " + arr2[0, 0]);               ///1
            Console.WriteLine("arr2[0,2] : " + arr2[0, 2]);               ///3
            Console.WriteLine("arr2[1,2] : " + arr2[1, 2]);               ///7
            Console.WriteLine("arr2[2,3] : " + arr2[2, 3]);               ///12
            Console.WriteLine();


            /// 3차원 배열(Cube 직방체)
            int[,,] arr3 = {
                             { { 1,2,3},
                                {4,5,6},
                                {7,8,9} },

                             { {10,11,12},
                               {13,14,15},
                               {16,17,18} },

                             { {19,20,21},
                               {22,23,24},
                               {25,26,27} }
                             };
            Console.WriteLine();


            Console.WriteLine("arr3[0,0,2] : " + arr3[0, 0, 2]);              ///3
            Console.WriteLine("arr3[0,1,1] : " + arr3[0, 1, 1]);              ///5
            Console.WriteLine("arr3[1,0,1] : " + arr3[1, 0, 1]);              ///11
            Console.WriteLine("arr3[1,2,1] : " + arr3[1, 2, 1]);              ///17
            Console.WriteLine("arr3[2,2,0] : " + arr3[2, 2, 0]);              ///25
            Console.WriteLine();










        }
        
    }
}
