using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///매개변수 없는 생성자 p407

namespace Book.Ch08
{
    class Ch08_8
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            Point p = new Point();                   //매개변수 없는 생성자 ???????????

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
    }




    internal class p407
    {
    }
}
