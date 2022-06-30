using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Deligate (대리자) : method라는 행위를 변수로 활용 즉, 매개변수로 전달하거나 반환하거나 연산자로 활용.
///                        (method = 행위 , variable = data/value )
///                        Class와 같은 자료형으로 일종의 class 선언
///
///    매개변수 : deligate 변수를 초기화
///    1.method명
///    
///    2.무명 deligate : 정렬할 때마다 정렬의 종류만큼 method를 만들기 힘들어서 이러한 코드를 간단하게 하고자 사용
///                     변수.Sort( delegate(매변, 매변){  return;  } );
///    
///    3.Lamda(익명 deligate) : delegate를 더 짧게 사용하는 것
///                            (매변,매변) => {    return  ;   }



///     (Sort() method 내부 딱히 입력할 코드가 없을 경우)
///        variable.Sort( (a,b)  =>  return   )
///        variable.Sort( (a,b)  =>           )


///   Comparison Deligate :
///   
///   Comparison<T> 대리자
///    public delegate int Comparison<in T> ( T x, T y );       - int자료형을 반환하고 generic을 사용한 매개변수 두 개
///
///     Microsoft : https://docs.microsoft.com/ko-kr/dotnet/api/system.comparison-1
///


namespace Book.Ch11
{
    internal class p496_502
    {
        delegate void Test();               ///Test : deligater
        /// Test t1 = ;          -          자료형으로 변수 초기화 (deligate 변수를 초기화 : method명 / 무명deligate / Lamda)    





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



            ///1. 메서드 이름                                                 정렬하는 中, 택 1
            p.Sort(Method_N);


            ///2. 무명 deligate                                               
            p.Sort (  delegate(Product a, Product b){  return a.Price.CompareTo(b.Price); }  );


            ///3. Lamda(익명 method)
            p.Sort(   (a, b) => { return a.Price.CompareTo(b.Price); }    );      ///lamda
            p.Sort(   (a, b) => a.Price.CompareTo(b.Price)                );      ///lamda  더 간단한 형태






            foreach (var item in p)                                           ///출력
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

           
        }

        /// 1-1. 메서드 이름
        static int Method_N(Product a, Product b){  return a.Price.CompareTo(b.Price); }



    }





}
