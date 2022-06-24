using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Deligate  : method라는 행위를 변수처럼 활용. 즉 method 자체를 매개변수로 전달하거나 반환하거나 연산자로 활용.
///                (method = 행위 , variable = data/value ) 
///    Lamda     : delegate를 조금 더 짧게 사용하는 것
/// 
/// 
/// 
///    Deligate는 일종의 클래스 선언  
///             ex) class TestClass{}
///                 TestClass t = new TestClass()
///
///                 delegate void TestDelegate();
///                 TestDelegate t1 = <methodName, 무명Deligate, Lamda> : Delegate 변수를 초기화하는 방법
/// 



namespace Book.Ch11
{
    internal class p497_499
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

            p.Sort(SortWithPrice);                                      ///1-2 Sort() method의 매개변수로 method 지정 / Comparison deligate가 지정하는 int자료형을 반환하고, '매개변수를 두 개 받는 method'를 매개변수로 지정            
            foreach (var item in p)                                    
            {
                Console.WriteLine(item.Name + " : " + item.Price);        
            }
        }

        static int SortWithPrice(Product a, Product b)                  ///1-1 Sort() method의 매개변수로 method 지정 / Comparison deligate가 지정하는 int자료형을 반환하고, '매개변수를 두 개 받는 method'를 매개변수로 지정 
        {
            return a.Price.CompareTo(b.Price);                         
        }


        ///   Comparison Deligate :
        ///   
        ///   Comparison<T> 대리자
        ///    public delegate int Comparison<in T> ( T x, T y );       - int자료형을 반환하고 generic을 사용한 매개변수 두 개
        ///
        ///     Microsoft : https://docs.microsoft.com/ko-kr/dotnet/api/system.comparison-1
        ///



    }
}
