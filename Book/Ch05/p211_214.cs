using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     class name  -   dataType        -      new dataType[저장공간] 
///     List           <dataType>       -      new dataType[저장공간]
///   





namespace Book.Ch05
{
    internal class p211_214
    {
        static void Main1(string[] args)
        {
            /// Array
            int[] arr1 = new int[10];                   ///배열(10개의 저장공간) 생성  
            long[] arr2 = new long[10];
            string[] arr3 = new string[10];


            /// List class 
            List<int> l1 = new List<int>();
            ///list.


            /// List
            List<int> l1 = new List<int>();       ///list class 변수 선언

            l1.Add(10);                           ///list class에 요소 추가
            l1.Add(20);
            l1.Add(30);
            l1.Add(40);

            foreach (var item in l1)             ///반복
            {
                Console.WriteLine("Count : " + l1.Count + "\t item : " + item);     ///결과 : count : 4 , itme : 10, 20, 30, 40    
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
