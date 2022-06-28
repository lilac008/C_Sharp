using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     속성 : get, set을 속성으로 변환하여 쉽게 만듬 (대문자가 규칙)
///    
///   public dT 속성명(*)              -  * 반드시 대문자
///   {
///      get { return variable; }
///      set { variable = value; }
///    }
///    
///      instance명.속성명          //get 호출
///      instance명.속성명 = 값     //set 호출
///      




///          읽기/쓰기(get, set), 읽기전용(get만 포함), 쓰기 전용(set만 포함, 주요한 데이터에 대한 접근을 제한, 거의 없다.) 
///           
///           get 속성 접근자 : 속성 값을 반환  
///           set 속성 접근자 : 새 값을 할당              
/// 



namespace Book.Ch06
{
    internal class p297_299
    {
        class Box
        {
            private int width;                                         
            public int W                                           /// 속성(Capital letter)
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }                 
                    else { Console.WriteLine("너비는 자연수로 입력해야!"); }
                }
            }

            private int height;
            public int H                                          /// 속성(Capital letter)                            
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수로 입력해야!"); }
                }
            }

            public Box(int width, int height)                              /// Constructor
            {
                W = width;
                H = height;
            }

            public int Area() { return this.width * this.height; }         // instance method
        }

        static void Main1(string[] args)
        {
            Box b = new Box(-10, -20);
            /// b.                                       // 속성을 의미 : 엔지니어 모양  - Width, Height(둘다 대문자)  

            b.W = -200;
            b.H = -100;
        }






    }
}
