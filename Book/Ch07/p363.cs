using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///    3) Overriding - virtual / override  method

namespace Book.Ch07
{


    class Program8
    {
        class Parent
        {
            public virtual void Method() { Console.WriteLine("모의 method"); }         /// virtual - 모class method
        }

        class Child : Parent
        {
            public override void Method() { Console.WriteLine("식의 method"); }        ///override - 식class method
        }

        static void Main(string[] args)
        {
            Child v1 = new Child();
            v1.Method();
            ((Parent)v1).Method();
        }




    }



    internal class p363
    {



    }
}
