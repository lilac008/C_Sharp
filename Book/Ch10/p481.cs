using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     예외 강제 발생 : 
  
///  try {  throw new Exception();  }
///  catch (Exception e) {            }

///  if () {         }
///  else  {  throw new Exception();  }




namespace Book.Ch10
{
    internal class p481
    {
        class ClassBox
        {
            private int width;                              
            public int W                                            /// 속성
            {
                get 
                { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { throw new Exception("너비는 자연수로 입력"); }          
                }
            }

            private int height;
            public int H                                            /// 속성
            {
                get 
                { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { throw new Exception("높이는 자연수로 입력"); }          
                }
            }

            public ClassBox(int width, int height)                  /// 생성자
            {
                W = width;
                H = height;
            }

            public int Area() 
            { return this.width * this.height; }                  ///istance method
        }

        static void Main1(string[] args)
        {
            ClassBox b = new ClassBox(-10, -20);

        }
    }
}
