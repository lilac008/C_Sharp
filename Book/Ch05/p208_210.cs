using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p208_210
    {
        static void Main1(string[] args)
        {

            // Random 클래스

            ///Random r1 = new Random();
            ///r1.


            // Random - 임의의 정수 
            Random r2 = new Random();
            Console.WriteLine(r2.Next(10, 100));
            Console.WriteLine(r2.Next(10, 100));
            Console.WriteLine(r2.Next(10, 100));
            Console.WriteLine(r2.Next(10, 100));
            Console.WriteLine(r2.Next(10, 100));
            Console.WriteLine();

            // Random - 임의의 실수
            Random r3 = new Random();
            Console.WriteLine(r3.NextDouble());
            Console.WriteLine(r3.NextDouble());
            Console.WriteLine(r3.NextDouble());
            Console.WriteLine(r3.NextDouble());
            Console.WriteLine();

            // Random - 임의의 실수 * 숫자 (0~ 숫자 범위의 실수 난수 생성)
            Random r4 = new Random();
            Console.WriteLine(r4.NextDouble() * 10);
            Console.WriteLine(r4.NextDouble() * 10);
            Console.WriteLine(r4.NextDouble() * 10);
            Console.WriteLine(r4.NextDouble() * 10);
            Console.WriteLine();














        }
    }
}
