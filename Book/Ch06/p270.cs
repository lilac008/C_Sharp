]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Book.Ch06
{



    class Ch06_5
    {
        class Test
        {
            public int Multiply(int min, int max)                       ///int 자료형은 최댓값을 쉽게 돌파해서 overflow가 발생하기 쉬우니 long 추천
            {
                int output = 1;
                for (int i = min; i <= max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }

        static void Main1(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.Multiply(1, 10));
        }
    }




    internal class p270
    {
    }
}
