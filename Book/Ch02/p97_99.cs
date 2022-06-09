using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p97_99
    {
        static void Main1(string[] args)
        {
            //지역 변수 - 이미 만들어진 변수의 자료형 확인 : (변수 n에 커서두기)
            int n = 10;
            Console.WriteLine(n);
            Console.WriteLine();

            // Get Type() - 간접
            int a = 273;
            long b = 522731033265;
            float c = 52.273F;
            double d = 52.273;
            char e = '문';
            string f = "문자열입니다.";

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine();

            //Get Type() - 직접 
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());
            Console.WriteLine();











        }

    }
}
