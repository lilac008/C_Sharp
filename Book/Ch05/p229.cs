using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///  Variable              :  method에 정의된 객체 
///  Instance variable     :  class에 정의된 객체. 소문자가 규칙. (대게 private으로 선언된다.)
///  
///  Class variable/method :  instance필요없이 곧바로 사용하는 variable/method.  키워드 static을 사용한다. ex) Math.Abs() 


namespace Book.Ch05
{
    internal class p229
    {
        /// AccessModifier - static - dataType - variable
        class MyMath
        {
            public static double PI = 3.141592;        ///변수 선언과 동시에 초기화
        }

        static void Main1(string[] args)
        {
            Console.WriteLine(MyMath.PI);             /// 따로 instance 필요없이 class 이름을 variable과 method로 사용하는 것, ex) Math.Abs() 
        }






    }
}
