using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///    sealed - 1) class에 올 경우 : 절대 상속하지 말것
///           - 2) method에 올 경우 : 더 이상 overriding 하지 말것


namespace Book.Ch07
{

    class Program13
    {
        class Parent
        {
            public virtual void Test() { }
        }

        class Child : Parent
        {
            sealed public override void Test() { }     /// 1) sealed가 method에 올 경우 - overriding 금지
        }

        class GrandChild : Child
        {
            ///public override void Test() { }        /// 2) 오류 
        }

        static void Main1(string[] args)
        {
            Parent p1 = new Parent();
            Child c1 = new Child();

            p1.Test();
            c1.Test();
        }


    }







    internal class p370
    {
    }
}
