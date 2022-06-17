using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    class Ch06_2
    {
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }

        static void Main1(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.Multi(52, 273));
            Console.WriteLine(t.Multi(103, 32));
        }
    }


    internal class p267
    {
    }
}
