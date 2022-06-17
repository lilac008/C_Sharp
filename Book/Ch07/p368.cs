using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///    sealed - 1) class에 올 경우 : 절대 상속하지 말것
///           



namespace Book.Ch07
{

    class Program12
    {
        sealed class Parent           /// 1) sealed가 class에 올 경우 : 상속 금지
        {
            public void Test() { }
        }

        class Child ///: Parent       /// 2) 오류
        {
            public void Test() { }
        }

        static void Main1(string[] args)
        {
            Parent p1 = new Parent();
            Child c1 = new Child();

            p1.Test();
            c1.Test();
        }


    }



    internal class p368
    {





    }
}
