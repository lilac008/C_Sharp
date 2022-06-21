using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022/06/07
 * 이름 : 최희원
 * 내용 : Method Overloading (p275)
 * 
 * 
 *   Method Overloading : - 같은 이름의 method를 parameter(매개변수. method 실행시 필요한 값.)로 구분한 method.
 *                        - method 반환타입은 Overloading에 영향을 미치지 않는다.
 *  
 *  
 *  overloadding 
 *  cf. overriding 
 * 
 */


namespace Ch04
{
    internal class _3_MethodOverload
    {

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static string Plus(string a, string b)
        {
            return a + b;
        }

        static void Main1(string[] args)
        {

            ///호출
            int r1 = Plus(1, 2);
            int r2 = Plus(1, 2, 3);
            double r3 = Plus(1.01, 2.3);
            string r4 = Plus("Hello", "World");

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);

        }


    }
}
