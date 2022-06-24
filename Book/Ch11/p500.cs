using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    무명 Delegate : 정렬할 때마다 정렬의 종류만큼 method를 만들기 힘들어서 이러한 코드를 간단하게 하고자 사용
///    
///                    delegate(<매개변수>, <매개변수>)
///                    {
///                        return 반환 ;
///                    }
/// 


namespace Book.Ch11
{
    internal class p500
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static void Main1(string[] args)
        {
            List<Product> p = new List<Product>()
            {
                new Product(){ Name = "당근",   Price = 100 },
                new Product(){ Name = "사과",   Price = 200 },
                new Product(){ Name = "오렌지", Price = 300 },
                new Product(){ Name = "딸기",   Price = 400 },
                new Product(){ Name = "청포도", Price = 500 }
            };

            p.Sort(
             delegate (Product a, Product b)                                ///무명 delegate로 정렬 방법을 정의.
             {
                 return a.Price.CompareTo(b.Price);
             }
            );


            foreach (var item in p)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }




    }
}
