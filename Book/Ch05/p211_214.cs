using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     className -  dataType        -      new    dataType[저장공간] 
///     List         <dataType>       -      new    dataType[저장공간]
///

 
 
///       new : class 타입의 instance를 생성해주는 역할
///             Heap에 데이터를 저장할 공간을 할당받고, 그 공간의 참조값(reference value)을 객체에게 반환하고, 생성자를 호출한다.
///       
///     Class    variable  =  new           class();
///     자료형    참조값      instance생성   생성자 호출     



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
            List<int> list = new List<int>();
            //list.


            /// List
            List<int> li = new List<int>();       ///list class 변수 선언

            li.Add(10);                           ///list class에 요소 추가
            li.Add(20);
            li.Add(30);
            li.Add(40);

            foreach (var item in li)             ///반복
            {
                Console.WriteLine("Count : " + li.Count + "\t item : " + item);     ///결과 : count : 4 , itme : 10, 20, 30, 40    
            }


            Console.WriteLine();



            /// List 생성 및 요소 추가
            List<int> li02 = new List<int>() { 52, 273, 32, 64 };

            foreach (var item in li02)
            {
                Console.WriteLine("Count : " + li02.Count + "\t item : " + item);
            }

            Console.WriteLine();


            /// List 요소 제거
            /// list-Variable.Remove(제거요소);  
            List<int> li03 = new List<int>() { 52, 273, 32, 64 };

            li03.Remove(52);

            foreach (var item in li03)
            {
                Console.WriteLine("Count : " + li03.Count + "\t item" + item);
            }






        }
    }
}
