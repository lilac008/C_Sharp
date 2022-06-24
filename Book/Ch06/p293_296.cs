using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///      get, set  :  private 선언시 method 호출, 변경
///      
///      get  :  다른 class에서 값 호출
///      set  :  다른 class에서 값 수정
///




namespace Book.Ch06
{
    internal class p293_296
    {

        class Box
        {
            private int width;                                          /// private (접근 불가)
            private int height;

            public Box(int width, int height)                           /// Constructor
            {
                if (width > 0 || height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else
                {
                    Console.WriteLine("너비, 높이는 자연수로 초기화해야!");
                }
            }

            public int Area()                                                 // instance method
            {
                return this.width * this.height;
            }

            public int getWidth() { return width; }                            /// Get : 다른 class에서 값 호출
            public int getHeight() { return height; }


            public void setWidth(int width)                                   /// Set : 다른 class에서 값 수정
            {
                if (width > 0) { this.width = width; }
                else
                { Console.WriteLine("너비는 자연수로 입력해야!"); }
            }

            public void setHeight(int height)
            {
                if (height > 0) { this.height = height; }
                else
                { Console.WriteLine("높이는 자연수로 입력해야!"); }
            }




            static void Main1(string[] args)
            {

            }
        }



    }
}
