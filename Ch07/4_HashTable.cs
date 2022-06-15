using Ch07.Sub1;
using System;
using System.Collections;   //ctrl+. - using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022 / 06 / 15
 * 이름 : 최희원
 * 내용 : Collection - HashTable, Dictionary ()
 * 
 * HashTable : Key-Value(키와 값)의 쌍으로 이루어진 자료구조
 *             키를 이용해 ArrayList보다 탐색 속도가 빠르고 편리
 * 
 * Dictionary : HashTable을 일반화시킨 컬렉션.
 *              HashTable보다 더 나은 성능을 제공.
 * 
 * 
 * ex)
 * Key Value
 * A   Apple
 * B   Banana
 * C   Cherry
 * 
 * 
 * 
 */


namespace Ch07
{
    internal class _4_HashTable
    {
        static void Main1(string[] args)
        {

            //HashTable
            Hashtable t1 = new Hashtable();    //테이블(표) 생성

            t1['A'] = "Apple";
            t1['B'] = "Banana";
            t1['C'] = "Cherry";

            Console.WriteLine("HashA : " + t1['A']);     //데이터 출력
            Console.WriteLine("HashB : " + t1['B']);
            Console.WriteLine("HashC : " + t1['C']);
            Console.WriteLine();

            foreach (char k in t1.Keys)                       //반복 출력
            {
                Console.WriteLine(t1[k]);
            }
            Console.WriteLine();




            //Dictionary - (1)
            Dictionary<char, string> dic = new Dictionary<char, string>();

            ///dic['A'] = "Apple";
            ///dic['B'] = "Banana";
            ///dic['C'] = "Cherry";

            dic['A'] = "Apple";
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");

            Console.WriteLine("DicA : " + dic['A']);
            Console.WriteLine("DicB : " + dic['B']);
            Console.WriteLine("DicC : " + dic['C']);
            Console.WriteLine();

            foreach (string fruit in dic.Values)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();


            //Dictionary - (2)
            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(101, "김유신");
            people.Add(102, "김춘추");
            people.Add(103, "장보고");
            people.Add(104, "강감찬");
            people.Add(105, "이순신");

            foreach (int k in people.Keys) { Console.WriteLine(people[k]); }
            Console.WriteLine();




            //Dictionary, List 응용
            Dictionary<int, Apple> d1 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d2 = new Dictionary<int, Apple>();
            Dictionary<int, Apple> d3 = new Dictionary<int, Apple>();

            ///   d1          d2           d3
            ///  k   v       k   v        k    v
            ///  1  사과     4   사과
            ///  2  사과     5
            ///  3  사과     6


            d1.Add(101, new Apple("한국", 3000));
            d1.Add(102, new Apple("미국", 2000));
            d1.Add(103, new Apple("이집트", 1000));

            d2.Add(201, new Apple("중국", 3000));
            d2.Add(202, new Apple("영국", 2000));
            d2.Add(203, new Apple("인도", 1000));

            d3.Add(301, new Apple("일본", 3000));
            d3.Add(302, new Apple("프랑스", 2000));
            d3.Add(303, new Apple("멕시코", 1000));

            ///List<> apples = new List<>();    
            /// + Dictionary<int, Apple>
            List<Dictionary<int, Apple>> apples = new List<Dictionary<int, Apple>>();
            apples.Add(d1);
            apples.Add(d2);
            apples.Add(d3);


            // 한국 사과
            Dictionary<int, Apple> d = apples[0];
            Apple a = d[101];
            a.Show();
            Console.WriteLine();

            // 미국 사과
            ///Dictionary<int, Apple> d = apples[0];
            ///Apple a = d[102];
            ///a.Show();

            apples[0][102].Show();
            Console.WriteLine();

            // 영국 사과
            apples[1][202].Show();
            Console.WriteLine();

            // 멕시코 사과
            apples[2][303].Show();















        }


    }
}
