using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    class Program3
    {
        class Parent
        {
            public static int v = 0;                                /// static, class variable
            public void CountParent() { Parent.v++; }               
        }

        class Child : Parent
        {
            public void CountChild() { Child.v++; }
        }


        internal class p354_355__
        {
            static void Main1(string[] args)
            {
                Parent a1 = new Parent();
                Child b1 = new Child();

                a1.CountParent();
                b1.CountChild();

                Console.WriteLine(Parent.v);
                Console.WriteLine(Child.v);
                Console.WriteLine(Child.v);


            }
        }
    }







}
