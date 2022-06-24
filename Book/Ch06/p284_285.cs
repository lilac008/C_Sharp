using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///       Constructor (생성자)   : 뭔가를 생성할 때 자동으로 호출되는 method       
///       
///       Instance 생성자  : instance를 생성할 때 자동으로 호출되는 method  / instance 변수 선언 및 초기화
///                                1. class명과 동일해야 함
///                                2. 접근제한자는 public (private은 기능이 다름)
///                                3. 반환과 관련된 선언은 하지 않음
///
///       Private 생성자  :  1. 정적(static?) 멤버만 가지고 있을 때                    ex)Math Class - instance를 생성하지 못하게 private 생성자를 정의함(C#에서는 Math Class도 instnace 생성이 가능)
///                          2. instance를 factory method로만 생성하게 하고 싶을 때     / factory method(모class에 숨겨진 식class의 instance를 만듬)
///
///       Static 생성자   :  1. 접근제한자 사용 불가
///                          2. 매개변수 사용 불가 



namespace Book.Ch06
{
    class Ch06_13
    {


        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)               /// Constructor
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }

        static void Main1(string[] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine(productA.id + ":" + productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(Product.counter + "개 생성되었습니다");

        }
    }


    internal class p284_285
    {
    }
}
