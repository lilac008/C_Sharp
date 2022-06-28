using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     out : method 호출시 return할 때 하나의 값이 아닌 여러 개의 값을 반환

///     public static bool TryParse (stirng s, out int result);
///      dT .TryParse(dT 매개변수, out  dT 매개변수); true :  숫자로 바꿀 수 있는 문자열     
///                                                  flase :               없는




namespace Book.Ch08
{

    class Ch08_5
    {

        static void Main1(string[] args)
        {
            Console.WriteLine("숫자 입력 : ");
            int v;                                                    
            bool result = int.TryParse(Console.ReadLine(), out v);    ///매개변수(out v) 없이 숫자 data를 바로 집어넣으면 오류 발생

            if (result) 
            { Console.WriteLine("입력한 숫자 : " + v); }
            else { Console.WriteLine("숫자를 입력!"); }

        }

    }




    internal class p401
    {
    }
}
