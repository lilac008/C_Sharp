using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     Constructor : instance 생성 시 실행되는 method
///     
/// 
///     Destructor  : 더 이상 변수를 사용하지 않을 때, object를 소멸시키며 소멸자를 호출
///                   1. class name 앞에 ~를 붙인다. 하나의 class에는 하나의 소멸자만 있을 수 있다.
///                   2. 접근 제한자 X
///                   3. 반환과 관련된 선언 하지 않음.
///

namespace Book.Ch06
{
    internal class p289
    {

        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            ~Product()
            { Console.WriteLine(this.name + "의 소멸자 호출"); }           ///??????????????????

        }


        static void Main1(string[] args)
        {


            Product p = new Product("과자", 1000);

            ///Console.WriteLine(p.name + "의 소멸자 호출");           ???


        }


    }
}
