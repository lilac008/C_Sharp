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
    class Ch06_12
    {
        class Product
        {
            public string Name;
            public int price;

            public Product(string name, int price)          /// Constructor 
            {
                this.Name = name;
                this.price = price;
            }
        }
    }


    internal class p283
    {
    }
}
