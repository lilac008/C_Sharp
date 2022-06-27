using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Struct의 초기화 형태



namespace Book.Ch08
{

    class Ch08_10
    {
        struct ClassA
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
            public Ch08_10 program;


            public ClassA(int x, int y)                             ///생성자 overloading
            {
                this.x = x;
                this.y = y;

                this.testA = "초기화";
                this.testB = "초기화";

                this.program = null;                                 /// null로 초기화

            }

            public ClassA(int x, int y, string test)                ///생성자 overloading
            {
                this.x = x;
                this.y = y;

                this.testA = test;
                this.testB = test;

                this.program = null;
            }
        }


        static void Main1(string[] args)
        {
        }
    }

    internal class p409_410
    {
    }
}
