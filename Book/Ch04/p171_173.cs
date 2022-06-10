using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p171_173
    {
        static void Main1(string[] args)
        {

            //foreach

            // dataType[] 변수 = {배열} 
            // foreach(dataType 변수 in 배열변수)
            // {
            // }
            //
            // dataType[] 변수 = 배열
            // for (dataType 변수 = 0; 변수 < Collection.길이; 변수++)
            // {
            //      dataType 변수 = Collection[변수] 
            // } 


            // foreach - 
            string[] arr = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();


            // foreach - 
            string[] arr1 = { "체리", "무화과", "밤", "딸기", "귤" };
            foreach (var a1 in arr1)
            {
                Console.WriteLine(a1);
            }
            Console.WriteLine();


            //코드 조각 
            //
            //for, if, while, for, foreach    +     tab
            //




















        }
    }
}
