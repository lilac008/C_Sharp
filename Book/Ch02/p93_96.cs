using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p93_96
    {
        static void Main1(string[] args)
        {
            //증감 연산자 - 한 줄에 독립적으로 사용할 경우
            int n = 10;
            n++;
            Console.WriteLine(n);
            n--;
            Console.WriteLine(n);
            ++n;
            Console.WriteLine(n);
            --n;
            Console.WriteLine(n);
            Console.WriteLine();


            //증감 연산자 - 후위 
            int n1 = 10;
            Console.WriteLine(n1);
            Console.WriteLine(n1++);  
            Console.WriteLine(n1--);    
            Console.WriteLine(n1);
            Console.WriteLine();

            //증감 연산자 - 전위 
            int n2 = 10;
            Console.WriteLine(n2);
            Console.WriteLine(++n2);
            Console.WriteLine(--n2);
            Console.WriteLine(n2);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            //후위 증감연산자 풀이
            int n3 = 10;
            Console.WriteLine(n3);
            Console.WriteLine(n3); n3 += 1; 
            Console.WriteLine(n3); n3 -= 1; 
            Console.WriteLine(n3);
            Console.WriteLine();

            //전위 증감연산자 풀이
            int n4 = 10;
            Console.WriteLine(n4);
            n4 += 1; Console.WriteLine(n4);  //
            n4 -= 1; Console.WriteLine(n4);  //
            Console.WriteLine(n4);
            Console.WriteLine("--------------------------");
            Console.WriteLine();



            //증감 연산자 이해도 확인
            int n5 = 10;
            Console.WriteLine(n5++);
            Console.WriteLine(++n5);
            Console.WriteLine(n5--);
            Console.WriteLine(--n5);
            Console.WriteLine();

            //여러 줄로 나누어 적은 증감 연산자
            int n6 = 10;
            Console.WriteLine(n6);
            n6++;
            n6++;
            Console.WriteLine(n6);
            Console.WriteLine(n6);
            n6--;
            n6--;
            Console.WriteLine(n6);
            Console.WriteLine();












        }
    }
}
