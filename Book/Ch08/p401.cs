using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     out : 값을 여러 개 반환하고 싶을 때
///     
///     
///     dataType.TryParse() : 
///     
///     TryParse() method 기본 형태 - public static bool TryParse (stirng s, out int result);                     
///                                                                         (out 키워드를 사용)              




namespace Book.Ch08
{

    class Ch08_5
    {

        static void Main1(string[] args)
        {
            Console.WriteLine("숫자 입력 : ");
            int v1;
            bool result = int.TryParse(Console.ReadLine(), out v1);

            if (result) { Console.WriteLine("입력한 숫자 : " + v1); }
            else { Console.WriteLine("숫자를 입력해주세요!"); }

        }

    }




    internal class p401
    {
    }
}
