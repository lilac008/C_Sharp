using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p229
    {
        class MyMath
        {
            // Class variable - static을 사용한다.              /  Class variable - 따로 instance 필요없이 바로 class 이름을 variable과 method로 사용하는 것, ex) Math.Abs() 
            /// [접근제한자] - [static] - [dataType] - [variable]
            ///                
            public static double PI = 3.141592;


        }

        static void Main1(string[] args)
        {
            Console.WriteLine(MyMath.PI);        ///  Class variable - 따로 instance 필요없이 바로 class 이름을 variable과 method로 사용하는 것, ex) Math.Abs() 

        }






    }
}
