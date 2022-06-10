using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p177_178
    {
        static void Main1(string[] args)
        {

            //break;

            while (true)
            {
                Console.Write("숫자 입력(짝수 입력시 종료): ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            // goto 
            // doNotUse:

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("◎외부◎");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부");
                    //goto doNotUse;
                }
            }
        doNotUse:
            Console.WriteLine("goto 키워드");















        }
    }
}
