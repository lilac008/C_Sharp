using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   재귀 메서드 : method 내부에서 자기자신을 호출하는 method.

namespace Book.Ch06
{
    internal class p306_307
    {
        class Fibonacci
        {
            public long Get(int i)                
            {
                if (i < 0) { return 0; }                 ///종료조건
                if (i == 1) { return 1; }                 ///종료조건

                return Get(i - 2) + Get(i - 1);
            }
        }

        class Program
        {

            static void Main1(string[] args)
            {
                ///재귀 Method : 자기자신호출 (무한반복)
                ///Main(new string[0]);    


                /// 재귀 Method - fibonacci instance method

                Fibonacci fibo = new Fibonacci();
                Console.WriteLine(fibo.Get(1));
                Console.WriteLine(fibo.Get(2));
                Console.WriteLine(fibo.Get(3));
                Console.WriteLine(fibo.Get(4));
                Console.WriteLine(fibo.Get(5));

            }
        }



    }
}
