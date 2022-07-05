using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/07
///     이름 : 최희원    
///     내용 : MethodType  (p265)
///
///     (F11눌러서 흐름 확인하기)

namespace Ch04
{
    internal class _2_MethodType
    {

        static void Main1(string[] args)
        {
            ///TypeA                                       
            double a1 = TypeA(0.1);                  
            double a2 = TypeA(1.2);

            Console.WriteLine("a1 : " + a1);
            Console.WriteLine("a2 : " + a2);
            Console.WriteLine();


            ///TypeB
            TypeB(true);                             
            TypeB(false);

            Console.WriteLine();


            ///TypeC
            string result = TypeC();
            Console.WriteLine("Type3 result : " + result);

            Console.WriteLine();


            ///TypeD
            TypeD();
        }


        public static double TypeA(double x)               /// 매개변수 o, 리턴값 o
        {
            double y = x + 3.14;
            return y;
        }


        public static void TypeB(bool status)             /// 매개변수 o, 리턴값 x
        {
            if (status)
            { Console.WriteLine("참"); }
            else
            { Console.WriteLine("거짓"); }
        }


        public static string TypeC()                      /// 매개변수 x, 리턴값 o
        {
            int n1 = 1, n2 = 2;

            if (n1 > n2)
                return "n1은 n2보다 크다.";
            else
                return "n1은 n2보다 작다.";
        }


        public static void TypeD()                        /// 매개변수 x, 리턴값 x
        {
            double result = TypeA(1.121);
            Console.WriteLine("Type4 result : " + result);
        }




    }
}
