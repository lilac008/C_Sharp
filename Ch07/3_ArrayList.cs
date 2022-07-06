using Ch07.Sub1;
using System;
using System.Collections;       //Ctrl+. - using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     날짜 : 2022/06/15
///     이름 : 최희원
///     내용 : Collection - ArrayList 
///
/// 
///     Array     : 정적 자료구조 (크기 고정. ex)4개로 지정하면 5개로 늘릴 수 없다.)
///     ArrayList : 동적 선형 자료구조 (입력되는 데이터에 따라 크기가 늘어나며 각 데이터를 처리할 수 있는 기능 제공)
///     List      : ArrayList를 일반화시킨 Collection. ArrayList보다 더 나은 성능. 
/// 




namespace Ch07
{
    internal class _3_ArrayList
    {
        static void Main1(string[] args)
        {

            // ArrayList
            ArrayList l1 = new ArrayList();

            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);

            ///데이터 삽입 
            ///list1.Insert(1, 6);        //index 1자리에 6을 삽입  

            ///데이터 삭제
            ///list1.Remove(6);        //data 6을 제거
            ///list1 = RemoveAt(0);    //index자리 0에서 1을 제거

            foreach (int n1 in l1)
            {
                Console.WriteLine(n1 + " ");
            }
            Console.WriteLine();



            // ArrayList - 다양한 형식
            ArrayList l2 = new ArrayList();

            l2.Add(100);
            l2.Add(0.123);
            l2.Add(true);
            l2.Add('A');
            l2.Add("Apple");

            for (int n2 = 0; n2 < l2.Count; n2++)
            {
                Console.WriteLine(l2[n2]);
            }
            ///Console.WriteLine(list2[0]);
            ///Console.WriteLine(list2[0]);
            ///Console.WriteLine(list2[0]);
            ///Console.WriteLine(list2[0]);
            ///Console.WriteLine(list2[0]);
            Console.WriteLine();




            // List - (1) (p211)
            List<int> l3 = new List<int>();

            l3.Add(1);
            l3.Add(2);
            l3.Add(3);
            l3.Add(4);
            l3.Add(5);

            foreach (int n3 in l3)
            { Console.WriteLine(n3 + " "); }
            Console.WriteLine();



            // List - (2)
            List<string> l4 = new List<string>();
            l4.Add("김유신");
            l4.Add("김춘추");
            l4.Add("장보고");
            l4.Add("강감찬");
            l4.Add("이순신");

            foreach (string n4 in l4)
            { Console.WriteLine(n4 + " "); }
            Console.WriteLine();




            // Apple - 객체 리스트
            List<Apple> l5 = new List<Apple>();

            ///Apple a1 = new Apple(new Apple("한국",3000));
            ///list5.Add(a1);

            l5.Add(new Apple("한국", 3000));
            l5.Add(new Apple("미국", 2000));
            l5.Add(new Apple("일본", 1000));

            Apple a1 = l5[0];
            a1.Show();                                   ///출력 : 한국
            Console.WriteLine();

            l5[1].Show();                                ///출력 : 미국
            Console.WriteLine();

            l5[2].Show();                                ///출력 : 일본







        }

    }
}
