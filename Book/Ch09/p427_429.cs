using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   Interface : 특정한 class를 만들때 사용하는 규칙   
///               1. interface class는 I가 붙는 것이 규칙
///               2. CompareTo() method를 구현해야 한다.
///              ex) sort() method를 구현한 객체만 넣어달라고 했는데 아닐시, 실수를 방지하고자 interface라는 기능을 제공 




namespace Book.Ch09
{

    internal class p427_429
    {


        class Product : IComparable                 ///1. IComparable 블록지정,  2-1  Ctrl. - 인터페이스구현 
        {                                           ///                          2-2  우클릭 - 빠른작업 리팩터링 - 인터페이스구현
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }

            public int CompareTo(object obj)                             /// IComparable interface 구현
            {
                return this.Price.CompareTo((obj as Product).Price);     /// CompareTo() method를 구현,  CompareTo()를 무조건 구현하게 만들려면 IComparable interface를 사용해야 한다.
            }

            static void Main1(string[] args)
            {

                List<Product> li = new List<Product>()
                {
                    new Product(){ Name = "당근", Price = 1000 },
                    new Product(){ Name = "호박", Price = 2000 },
                    new Product(){ Name = "우엉", Price = 3000 },
                    new Product(){ Name = "연근", Price = 4000 },
                };
                li.Sort();                                             ///sort() method를 list에 정렬하고 싶으면 CompareTo() method를 구현해야 한다.

                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }

                ///IComparable com = new IComparable();                  // IComparable은 실체가 없는 규칙이므로 instance화 할 수 없다. 





            }



        }
















    }
}
