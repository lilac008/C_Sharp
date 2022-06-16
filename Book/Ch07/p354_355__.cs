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
            public static int var = 0;                                ///class variable 선언
            public void CountParent() { Parent.var++; }               /// Parent Class - variable 증가
        }

        class Child : Parent
        {
            public void CountChild() { Child.var++; }                 /// Child Class - variable 증가
        }


        internal class p354_355__
        {
            static void Main1(string[] args)
            {
                Parent p1 = new Parent();
                Child c1 = new Child();

                p1.CountParent();
                c1.CountChild();

                Console.WriteLine(Parent.var);
                Console.WriteLine(Child.var);
                Console.WriteLine(Child.var);

            }
        }
    }







}
