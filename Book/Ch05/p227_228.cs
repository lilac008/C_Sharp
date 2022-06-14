using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p227_228
    {
        class Program
        {
            class Product
            {
                // instance 변수 생성시 초기화
                ///
                /// public string name = "default";
                /// public int price = 1000; 
                /// 
                /// 

                public string name;
                public int price;

            }

            static void Main1(string[] args)
            {
                Product pA = new Product() { name = "감자", price = 2000 };
                Product pB = new Product() { name = "고구마", price = 3000 };
            }



        }







    }
}
