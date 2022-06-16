using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///   2-1) Hiding - variable



namespace Book.Ch07
{

    class Program5
    {
        class Parent
        {
            public int sameV = 273;
        }

        class Child : Parent
        {
            public string sameV = "shadowing/hiding";
        }

        static void Main1(string[] args)
        {
            Child c1 = new Child();
            Console.WriteLine(c1.sameV);


            /// 숨겨진 member 찾는법 (p359)
            ///
            /// ((모클래스)자식클래스변수).변수
            /// 
            Console.WriteLine();
            Console.WriteLine(((Parent)c1).sameV);
            Console.WriteLine(((Child)c1).sameV);
        }




        internal class p358_359
        {

        }

    }







}

