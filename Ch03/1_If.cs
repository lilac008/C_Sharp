using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     날짜 : 2022/06/03
///     이름 : 최희원    
///     내용 : If(true값) 조건문 (p127)
/// 


namespace Ch03
{
    internal class _1_If
    {
        static void Main1(string[] args)
        {
            /// If(true) { }
            int a1 = 1;
            int a2 = 2;

            if (a1 < a2)
            { Console.WriteLine("a1은 a2보다 작다."); }
            Console.WriteLine();

            if (a1 > 1)
            { Console.WriteLine("a1은 a1보다 크다."); }
            Console.WriteLine();


            if (a1 > 0)
            {
                if (a2 > 1)
                { Console.WriteLine("a1은 0보다 크고, a2는 1보다 크다."); }

            }
            Console.WriteLine();


            if (a1 > 0 && a2 > 1)
            { Console.WriteLine("a1은 0보다 크고 (그리고) a2는 1보다 크다."); }

            Console.WriteLine();
            Console.WriteLine("=============================");



            /// If(true) {   }
            /// else {  }
            int b1 = 1, b2 = 2;

            if (b1 > b2)
            { Console.WriteLine("b1은 b2보다 크다"); }
            else
            { Console.WriteLine("b1은 b2보다 작다."); }

            Console.WriteLine();
            Console.WriteLine("=============================");



            /// If(true) {   }
            /// else if(true) {  } 
            /// else {  }
            int n1 = 10, n2 = 20, n3 = 30, n4 = 40;

            if (n1 > n2)
            { Console.WriteLine("n1은 n2보다 크다."); }
            else if (n2 > n3)
            { Console.WriteLine("n2는 n3보다 크다."); }
            else if (n3 > n4)
            { Console.WriteLine("n3는 n4보다 크다."); }
            else
            { Console.WriteLine("n4가 가장 크다."); }

            Console.WriteLine();
            Console.WriteLine("=============================");





        }



    }
}
