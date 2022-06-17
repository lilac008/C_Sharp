using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///       Constructor (생성자)   : 뭔가를 생성할 때 자동으로 호출되는 method       
///       
///       Instance Constructor   : instance를 생성할 때 자동으로 호출되는 method  / instance 변수를 초기화 한다
///                                - class-name과 같아야 함
///                                - 접근제한자는 public이어야함 (private 생성자는 기능이 다름)
///                                - 반환과 관련된 선언은 하지 않음
///
///                                 public  class-name([변수])
///                                 {
///      
///                                 }



namespace Book.Ch06
{
    class Ch06_12
    {
        class Product
        {
            public string Name;
            public int price;

            public Product(string name, int price)
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
