using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Deligate (대리자) : method라는 행위를 변수처럼 활용 즉, method 자체를 매개변수로 전달하거나 반환하거나 연산자로 활용.
///                        (method = 행위 , variable = data/value )
///                        Class와 같은 자료형이다.
///                        
///      delegate void Test();
///      Test t1 = ( method명 / 무명deligate / Lamda : 대리자 변수를 초기화)    
///     



namespace Book.Ch11
{
    internal class p496
    {
        class Product
        {
            public string Name { get; set; }
            public int Price   { get; set; }
        }

        static void Main1(string[] args)
        {
            List<Product> p = new List<Product>()                         ///list 생성
            {
                new Product(){ Name = "당근",   Price = 500 },
                new Product(){ Name = "사과",   Price = 700 },
                new Product(){ Name = "오렌지", Price = 400 },
                new Product(){ Name = "딸기",   Price = 600 },
                new Product(){ Name = "청포도", Price = 300 }               
            };

                                                                         ///list 정렬
            
            foreach (var item in p)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            //p.Sort()             // sort() method의 두 번째 형태       


            //Comparison          //Comparison 의 자료형은 deligate다.
        }



    }





}
