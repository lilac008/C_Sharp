using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///구조체는 생성자에서 모든 변수를 초기화해야 함



namespace Book.Ch08
{
    class Ch08_9
    {
        //struct Point
        //{
        public int x;
        public int y;
        public string testA;                     /// 초기화되지 않은 memeber 변수. 생성자를 만들려면 생성자에서 반드시 초기화해줘야 함.
        public string testB = "init";

        //public Point(int x, int y)               ///멤버 변수 testA를 초기화하지 않아 오류가 발생
        //{
        //    this.x = x;
        //    this.y = y;
        //}
        //}
    }




    internal class p408
    {
    }
}
