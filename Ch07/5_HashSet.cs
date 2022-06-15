using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022 / 06 / 15
 * 이름 : 최희원
 * 내용 : Collection - HashSet ()
 * 
 * 
 * 
 * HashSet : 입력되는 데이터 순서를 고려하지 않고, 중복을 허용하지 않는 구조
 *         - 중복된 데이터를 제거하거나 이미 데이터가 존재하는지 검사할 때 사용
 *         - 교집합, 합집합, 차집합
 * 
 * 
 * 
 */

namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main1(string[] args)
        {

            //HashSet
            HashSet<int> h = new HashSet<int>();      //var set = new HashSet<int>();

            h.Add(1);
            h.Add(2);
            h.Add(3);
            h.Add(4);
            h.Add(5);
            h.Add(2);
            h.Add(3);

            Console.WriteLine("집합 원소 갯수 : " + h.Count);
            Console.WriteLine();

            foreach (int n in h) { Console.WriteLine(n + " "); }
            Console.WriteLine();


            //HashSet - 교집합, 합집합, 차집합
            HashSet<int> h1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> h2 = new HashSet<int>() { 2, 3, 5, 6, 7 };

            var result1 = h1.Intersect(h2); //교집합
            var result2 = h1.Union(h2); //합집합
            var result3 = h1.Except(h2); //차집합

            foreach (int n in result1)
                Console.WriteLine(n + "");
            Console.WriteLine();

            foreach (int n in result2)
                Console.WriteLine(n + "");
            Console.WriteLine();

            foreach (int n in result3)
                Console.WriteLine(n + "");
            Console.WriteLine();














        }





    }
}
