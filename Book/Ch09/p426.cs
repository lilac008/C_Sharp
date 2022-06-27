using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  Interface             : 특정한 class를 만들때 사용하는 규칙, I가 붙는다.
///  IComparable Interface : 비교 가능한 자료
///  IDisposable Interface





namespace Book.Ch09
{

    internal class p426
    {
        class ClassA
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main1(string[] args)
        {

            List<ClassA> a = new List<ClassA>()
            {
                new ClassA(){ Name = "당근", Price = 1000 },
                new ClassA(){ Name = "호박", Price = 2000 },
                new ClassA(){ Name = "우엉", Price = 3000 },
                new ClassA(){ Name = "연근", Price = 4000 },
            };
            /// li.Sort();              /// 오류 : sort() method가 Product class를 어떤 기준으로 정렬해야할지 모르기 때문

            foreach (var item in a) 
            {
                Console.WriteLine(item);
            }

        }






    }
}
