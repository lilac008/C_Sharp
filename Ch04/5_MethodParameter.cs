using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : Method parameter (매개변수) 
///
/// 
///     ref 매개변수 : 변수의 reference(주소) 값으로 참조값이 가리키는 실제 변수에 값을 대입하는 매개변수
///     out 매개변수 : - 변수의 변수선언 없이 method 호출시 바로 method 결과를 리턴받는 매개변수
///                    - method는 하나의 리턴값을 여러개 리턴할 수 있는 
///


namespace Ch04
{
    internal class _5_MethodParameter
    {
        public static void Divider1(int a, int b, ref int quotient, ref int remainder)
        {
            quotient  = a / b;
            remainder = a % b;
        }

        public static void Divider2(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }



        static void Main1(string[] args)
        {

            /// Reference(참조) 매개변수
            int n1 = 10;
            int n2 = 3;
            int n3 = 0;
            int n4 = 0;

            Divider1(n1, n2, ref n3, ref n4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", n3, n4);



            /// Out(출력) 매개변수
            int nu1 = 10;
            int nu2 = 3;

            Divider2(nu1, nu2, out int nu3, out int nu4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", nu3, nu4);

        }




    }
}
