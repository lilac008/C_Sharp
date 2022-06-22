using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   재귀 메서드 : method 내부에서 자기자신을 호출하는 method.

namespace Book.Ch06
{
    internal class p308
    {
        class Fibonacci
        {
            public static long Get(int i)                ///static : class method 선언
            {
                if (i < 0) { return 0; }                  ///종료조건
                if (i == 1) { return 1; }                 
                if (i == 2) { return 1; }                 
                return Get(i - 2) + Get(i - 1);
            }
        }

        class Program
        {

            static void Main1(string[] args)
            {
 
                /// 재귀 Method - fibonacci instance method

                Fibonacci fibo = new Fibonacci();
                Console.WriteLine(Fibonacci.Get(1));
                Console.WriteLine(Fibonacci.Get(2));
                Console.WriteLine(Fibonacci.Get(3));
                Console.WriteLine(Fibonacci.Get(4));
                Console.WriteLine(Fibonacci.Get(5));

            }
        }



    }
}
