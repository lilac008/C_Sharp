using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  접근제한자  static  반환형   method-name(변수)
///  {
///           
///  }
///  

/// ex)         static    void     Main(string[] args)


///      [Class 내부의 Method를 직접사용할 때]  :  class-name.method-name()   
///       



namespace Book.Ch06
{

    class Ch06_6
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0)
                { return -input; }
                else
                { return input; }
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
        }
    }


    internal class p272_273
    {
    }
}
