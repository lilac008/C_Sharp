using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/03
 * 이름 : 최희원
 * 내용 : 입력  (p104)
 * 
 * 
 */


namespace Ch02
{
    internal class _4_InputTest
    {
        static void Main1(string[] args)
        {

            //이름 
            Console.WriteLine("이름 : ");
            string name = Console.ReadLine();
            Console.WriteLine("=======================");


            //나이 
            Console.WriteLine("나이 : ");
            string age = Console.ReadLine();
            Console.WriteLine("=======================");


            //주소 
            Console.WriteLine("주소 : ");
            string addr = Console.ReadLine();
            Console.WriteLine("=======================");


            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("주소 : " + addr);
            Console.WriteLine("=======================");


        }
    }
}
