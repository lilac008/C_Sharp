using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Constructor(생성자)
/// instnace
/// 

namespace Book.Ch07
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자"); }

        }

        class Child : Parent
        {
            public Child() : base()               ///base : Parent Constructor 호출을 명시적으로 지정하고 싶을때
            {
                Console.WriteLine("자식 생성자");
            }
        }



        internal class p351_352
        {
            static void Main1(string[] args)
            {

                Child c1 = new Child();          /// 자식 instance 생성

            }

        }


    }



}
