using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p225
    {
        static void Main1(string[] args)
        {

            class User
        {
            // instance 변수 : class에 정의된 변수로 소문자로 시작.
            /// [접근제한자] [dataType] [variable name]
            public string name;           // instance 변수 선언
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

            static void Main(string[] args)
            {
                Product v1 = new Product();

                product.name = "감자";          // instance.변수이름 
                product.price = 2000;

                Console.WriteLine(product.name + " : " + product.price + "원");

            }


        }








    }
    }
}
