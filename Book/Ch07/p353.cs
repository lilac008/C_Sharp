using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Constructor(생성자)
/// instnace

namespace Book.Ch07
{
    class Program2
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent() - 1"); }
            public Parent(int var) { Console.WriteLine("Parent(int var) - 2"); }                                                     /// 출력 1
            public Parent(string str) { Console.WriteLine("Parent(string str) - 3"); }                                               /// 출력 3
        }

        class Child : Parent
        {
            public Child() : base(10) { Console.WriteLine("Child() : base(10) - 4"); } ///base - Parent(int var) 부모생성자 호출      /// 출력 2
            public Child(string str2) : base(str2) { Console.WriteLine("(Child(string str2) : base(str2) - 5"); }                /// 출력 4
        }



        internal class p353
        {
            static void Main1(string[] args)
            {

                Child cA = new Child();                  ///instance 생성
                Child cB = new Child("string");

            }



        }
    }
}
