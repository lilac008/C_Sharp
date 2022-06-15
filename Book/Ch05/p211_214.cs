using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p211_214
    {
        static void Main1(string[] args)
        {

            // 배열 생성 
            int[] iArr = new int[10];                   //배열 생성 - 10개의 저장공간 가짐
            long[] lArr = new long[10];
            string[] sArr = new string[10];


            ///List<int> l1 = new List<int>();
            ///list.


            // List - 생성
            List<int> l2 = new List<int>();       //변수 선언

            l2.Add(52);                           //list에 요소 추가
            l2.Add(273);
            l2.Add(32);
            l2.Add(64);

            foreach (var item in l2)             //반복 수행
            {
                Console.WriteLine("Count : " + l2.Count + "\t item : " + item);
            }

            Console.WriteLine();



            // List - 생성 및 요소 추가
            List<int> l3 = new List<int>() { 52, 273, 32, 64 };

            foreach (var item in l3)
            {
                Console.WriteLine("Count : " + l3.Count + "\t item : " + item);
            }

            Console.WriteLine();



            // List - 요소 제거
            List<int> l4 = new List<int>() { 52, 273, 32, 64 };

            l4.Remove(52);

            foreach (var item in l4)
            {
                Console.WriteLine("Count : " + l4.Count + "\t item" + item);
            }






        }
    }
}
