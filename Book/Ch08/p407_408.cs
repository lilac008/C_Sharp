using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Book.Ch08
{
    class Ch08_8
    {
        struct Point
        {
            public int x;
            public int y;
            /// public string testA;                          /// 초기화되지 않은 멤버 변수. -> 생성자에서 초기화하지 않아 Point에서 오류 남.
            public string testB = "initialization(초기화)";   /// 선언과 동시에 초기화 X.    -> 생성자에서 초기화 가능. 


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




    internal class p407_408
    {
    }
}
