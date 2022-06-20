using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  날짜 : 2022/06/20 
///  이름 : 최희원
///  내용 : Throw (p479)
///   
/// 
///  

namespace Ch08
{
    class Box
    {
        private int width;
        private int height;

        public int Width 
        { 
            get { return width; }
            set
            {
                if (value > 0)
                { width = value; }
                else
                { throw new Exception("너비는 0보다 커야 합니다."); }         /// 가로 길이가 0보다 작을 경우의 예외를 강제 발생.           
            }

        }
        public int Height
        {
            get { return height; }
            set                                                             ///음수를 잘못 입력했을 경우, 예외처리를 위해 setter 수정???
            {
                if (value > 0)
                { height = value; }
                else
                { 
                    throw new Exception("높이는 0보다 커야 합니다.");        /// 세로 길이가 0보다 작을 경우 예외를 강제 발생
                }
            }
        }

        public Box(int width, int height)                                  ///생성자
        {
            Width = width;                                                ///this.Width = width;대신     setter 값 대입
            Height = height;                                              ///this.Height = height;대신   setter 값 대입
        }

        public void Area() 
        { 
            Console.WriteLine("box 넓이 : " + width * height); 
        }
    }



    internal class _2_Throw
    {
        static void Main1(string[] args)
        {

            ///Box b = new Box(10,-10);         -  음수를 잘못 입력했을 경우, 
            ///b.Area();

            try
            {
                Box box1 = new Box(10, 10);    /// 강제 발생된 예외를 처리
                box1.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
