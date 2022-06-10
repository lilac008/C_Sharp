using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p181
    {
        static void Main(string[] args)
        {

            // 변수.ToUpper() - 대문자화
            // 변수.ToLower() - 소문자화

            string a = "Potato Tomato";
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine();

            //(의미없는 method)
            string a1 = "Coca Cola";
            a1.ToUpper();                     //meaningless, non - destructive method
            Console.WriteLine(a1);
            Console.WriteLine();



            //변수.Split문자열 자르기
            string a2 = "감자, 고구마, 토마토";
            string[] arr = a2.Split(new char[] { ' ' });

            foreach (var b2 in arr)
            {
                Console.WriteLine(b2);

            }

            /* 다음과 같은 문자열 배열을 매개변수로 넣어서 사용할 수 있다.
             * string[] inputs = input2.Split(new string[]{ " " }), StringSplitOptions.RemoveEmptyEntries); 
             * 
             */


















        }
    }
}
