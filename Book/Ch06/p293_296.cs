using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///      private 선언시 get, set


namespace Book.Ch06
{
    internal class p293_296
    {

        class Box
        {
            private int width;                                             /// public(외부 접근 가능) -> private (외부 접근 불가)
            private int height;

            public Box(int width, int height)
            {
                if (width > 0 || height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비, 높이는 자연수로 초기화!");
                }
            }

            public int Area()                                                 /// 1-1. instance method
            {
                return this.width * this.height;
            }

            public int GetWidth() { return width; }                            /// 1-2. Get : 다른 class에서 값 호출
            public int GetHeight() { return height; }


            public void SetWidth(int width)                                   /// 1-3. Set : 다른 class에서 값 수정
            {
                if (width > 0) { this.width = width; }
                else
                { Console.WriteLine("너비는 자연수로 입력!"); }
            }

            public void SetHeight(int height)
            {
                if (height > 0) { this.height = height; }
                else
                { Console.WriteLine("높이는 자연수로 입력!"); }
            }




            static void Main1(string[] args)
            {

            }
        }



    }
}
