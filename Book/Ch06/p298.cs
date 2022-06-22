using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p298
    {
        class Box
        {
            private int width;
            public int Width                                           /// 속성 (대문자가 규칙)
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { Console.WriteLine("너비는 자연수로 입력!"); }
                }
            }

            private int height;
            public int Height                                           /// 속성 (대문자가 규칙)
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수로 입력!"); }
                }
            }

            public Box(int width, int height)                              /// Constructor
            {
                Width = width;
                Height = height;
            }

            public int Area() { return this.width * this.height; }         /// instance method

        }

        static void Main(string[] args)
        {
            Box b = new Box(-10, -20);

            b.Width = -200;
            b.Height = 100;

        }



    }
}
