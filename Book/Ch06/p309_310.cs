using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   재귀 메서드 : method 내부에서 자기자신을 호출하는 method.

///   메모화 : 

namespace Book.Ch06
{
    internal class p309_310
    {
        class Fibonacci
        {
            private static Dictionary<int, long> memo = new Dictionary<int, long>();    /// Dict object 생성
            public static long Get(int i)
            {
                if (i < 0) { return 0; }                     ///기본값
                if (i == 1) { return 1; }

                if (memo.ContainsKey(i)) { return memo[i]; }    ///이미 계산했던 값 확인
                else { long value = Get(i - 2) + Get(i - 1); memo[i] = value; return value; } ///계산하지 않았을시 계산
            }

        }

        class Program
        {
            static void Main1(string[] args)
            {
                Console.WriteLine(Fibonacci.Get(40));
                Console.WriteLine(Fibonacci.Get(100));



            }
        }



    }
}
