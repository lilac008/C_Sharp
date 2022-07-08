using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._05
{
    internal class _5_10
    {
        static void Main1(string[] args)
        {
            /// 배열 (정적)
            string[] arr = new string[5];                       ///배열개수 정해짐, 고정                 
            arr[0] = "dog";
            arr[1] = "cow";
            arr[2] = "rabbit";
            arr[3] = "goat";
            arr[4] = "sheep";

            Array.Sort(arr);                                    ///배열정렬  :  Array.Sort();

            Console.WriteLine("배열");
            foreach (string name in arr)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            /// 리스트 (동적)         
            List<string> lst = new List<string>();        ///배열개수가 정해지지 않음, 더 늘릴 수 있음
            lst.Add("dog");
            lst.Add("cow");
            lst.Add("rabbit");
            lst.Add("goat");
            lst.Add("sheep");

            lst.Sort();

            Console.WriteLine("리스트");                 ///리스트 정렬  :  변수.Sort();
            foreach (string name in lst)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }



}
