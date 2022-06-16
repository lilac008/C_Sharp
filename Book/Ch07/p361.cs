using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///  2-2) Hiding  -  new  method

namespace Book.Ch07
{

    class Program7
    {
        class Parent
        {
            public int sameV = 273;
            public void Method() { Console.WriteLine("부모의 메서드"); }
        }

        class Child : Parent
        {
            public new string sameV = "hiding";                                 /// new - variable를 hiding하겠다고 선언
            public new void Method() { Console.WriteLine("자식의 메서드"); }     /// new - method를 hiding하겠다고 선언
        }

        static void Main(string[] args)
        {
            Child v1 = new Child();
            v1.Method();
            ((Parent)v1).Method();
        }

    }


    internal class p361
    {





    }
}
