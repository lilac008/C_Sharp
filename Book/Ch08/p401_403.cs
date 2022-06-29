using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     out : method return할 때 하나의 값이 아닌 여러 개의 값을 반환할 때 사용되는 keyword.
///
///     public static bool TryParse (stirng s, out int Result);  - TryParse() : 숫자로 바꿀 수 있는 문자열을 넣으면 true, 아니면 flase로 반환 
///          .TryParse(string유형, out parameter)                  - Parse() : 매개변수 없이 숫자 data를 바로 집어넣으면 오류
///       int.TryParse("1000", out parameter)
///     float.TryParse("10.00", out parameter)
///     
/// 




namespace Book.Ch08
{

    internal class p401_403
    {
        /// 2
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;                             /// 다음위치 = 현재위치 + 현재속도
            ry = y + vy;
        }


        static void Main1(string[] args)
        {
            ///1
            Console.Write("숫자 입력 : ");
            int pt;                                                    
            bool b_ = int.TryParse(Console.ReadLine(), out pt);   


            if (b_) 
            { Console.WriteLine("입력한 숫자 : " + pt); }
            else 
            { Console.WriteLine("숫자를 입력해주세요!"); }



            ///2-1
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재 좌표 : (" + x + "," + y + ") ");
            NextPosition(x, y, vx, vy, out x, out y);                    /// out에 매개변수
            Console.WriteLine("다음 좌표 : (" + x + "," + y + ") ");



        }





    }





}
