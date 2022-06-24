using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Deligate (대리자) : method라는 행위를 변수처럼 활용. 즉 method 자체를 매개변수로 전달하거나 반환하거나 연산자로 활용.
///                        (method = 행위 , variable = data/value )
///                        
///    
///     class TestClass { }                       - 대리자는 일종의 class 
///     TestClass t = new TestClass()
///
///     delegate void TestDelegate();
///     TestDelegate t1 = /delegate 변수 초기화/    
///     
/// 
///    Delegate 변수를 초기화 방법 : 1) 메서드이름    : ????
///                                 2) 무명 Deligate : 
///                                 3) Lamda         : delegate를 조금 더 짧게 사용하는 것




namespace Book.Ch11
{
    internal class p496
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
                new Product(){ Name = "청포도", Price = 300 }               ///list 생성
            };                                                             ///list 정렬

            foreach (var item in p)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            //p.Sort()             // sort() method의 두 번째 형태       


            //Comparison          //Comparison 의 자료형은 deligate다.
        }



    }





}
