using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// throw new Exception(); - 강제로 예외 발생시키기

namespace Book.Ch10
{
    class Box
    {
        private int width;
        public int W
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { throw new Exception("너비는 자연수를 입력해주세요"); }          ///강제 예외 발생
            }
        }

        private int height;
        public int H
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { throw new Exception("높이는 자연수를 입력해주세요"); }          ///강제 예외 발생
            }
        }

        public Box(int width, int height)                                            /// 생성자
        {
            W = width;
            H = height;
        }

        public int Area() { return this.width * this.height; }                       ///istance method
    }




    internal class p481
    {
        static void Main1(string[] args)
        {
            Box b = new Box(-10, -20);

        }
    }
}
