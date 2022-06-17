using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///구조체에서 클래스 인스턴스를 멤버 변수로 선언

namespace Book.Ch08
{

    class Ch08_11
    {
        struct Point
        {
            public int x;
            public int y;
            //public Program program;

            public Point(int x, int y)
            {
                this.x = x;                                /// 구조체 내부에서 class instance를 member 변수로 선언할때도 무조건 초기화해야 한다.
                this.y = y;
                //this.program = null;                       ///초기화
            }
        }
    }


    internal class p410
    {
    }
}
