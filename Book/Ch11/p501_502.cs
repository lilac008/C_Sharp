using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///    Lamda : delegate를 조금 더 짧게 사용하는 것
///     
//       (매개변수,매개변수) => {
//           return /반환/ ;
//       }
///
///     (Sort() method 내부 딱히 입력할 코드가 없을 경우)
//        variable.Sort( (a,b)  =>  return  /반환/ )
//        variable.Sort( (a,b)  =>    /반환/       )


namespace Book.Ch11
{
    internal class p501_502
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
                new Product(){ Name = "당근",   Price = 500 },
                new Product(){ Name = "사과",   Price = 700 },
                new Product(){ Name = "오렌지", Price = 400 },
                new Product(){ Name = "딸기",   Price = 600 },
                new Product(){ Name = "청포도", Price = 300 }
            };

            p.Sort((a, b) => { return a.Price.CompareTo(b.Price); });      ///lamda
            p.Sort((a, b) => a.Price.CompareTo(b.Price));                  ///lamda  더 간단한 형태

            foreach (var item in p)
            {
                Console.WriteLine(item.Name + " : " + item.Price);            
            }





        }




    }
}
