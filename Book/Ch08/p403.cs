using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    class Ch08_6
    {
        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;            ///다음 위치 = 현재 위치 + 현재 속도
            ry = y + vy;
        }

        static void Main1(string[] args)
        {
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재 좌표 : (" + x + "," + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);                    ///out을 붙여서 매개 변수를 넣어줌
            Console.WriteLine("다음 좌표 : (" + x + "," + y + ")");
        }
    }


    internal class p403
    {
    }
}
