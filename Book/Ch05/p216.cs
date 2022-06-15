using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Class의 속성, method 확인법
 * 
 * https://docs.microsoft.com/ko-kr/documentation.
 * https://docs.microsoft.com/ko-kr/dotnet/api/system.math - math class 검색
 * 
 */


namespace Book.Ch05
{
    internal class p216
    {
        static void Main1(string[] args)
        {

            /*
             *   Math class member (instance 없이 사용 가능)
             * 
             *   Math.Abs()       : absolute value(절댓값)
             *   Math.Ceiling()   : 지정된 숫자보다 크거나 같은 최소 [정수]
             *   Math.Floor()     : 지정된 숫자보다 작거나 같은 최소 [정수]
             *   Math.Max(,)      : 두 변수 중 가장 큰 값
             *   Math.Min(,)      : 두 변수 중 가장 작은 값
             *   Math.Round()     : rounds(반올림)
             * 
             */


            //
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));










        }
    }
}
