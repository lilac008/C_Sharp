using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///접근제한자
///
/// public     : 모든 접근을 허용
/// protected  : 같은 패키지(폴더)에 있는 객체와 상속관계의 객체들만 허용
/// default    : 같은 패키지(폴더)에 있는 객체들만 허용
/// private    : 현재 object 내에서만 허용
 

namespace Book.Ch05
{
    internal class p225_226
    {

        class User
        {
            /// [접근제한자] [dataType] [instance variable] 
            ///                         instance 변수 : class에 정의된 변수로 소문자로 시작한다. 대게 private으로 선언 (아직 배우지 않아서 public으로)
            /// 
            public string name;
            public string password;
            public string address;
            public string phoneNumber;
            public DateTime regDate;
        }

        class Program
        {
            class Product
            {
                public string name;
                public int price;
            }

            static void Main1(string[] args)
            {
                Product v1 = new Product();

                v1.name = "감자";          // instance.변수
                v1.price = 2000;

                Console.WriteLine(v1.name + " : " + v1.price + "원");
            }

        }








    }
}
