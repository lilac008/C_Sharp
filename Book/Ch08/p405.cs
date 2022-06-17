using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 구조체 : 간단한 객체를 만들 때 사용하는 형식 (상속 불가, 인터페이스 구현 불가)
/// 


///int         ///int 빗금 - readonly struct System.Int32 (부호있는 32비트 정수를 나타냄)
///



namespace Book.Ch08
{

    class Ch08_7
    {
        struct Point                                   /// 구조체 선언
        {
            public int x;
            public int y;


            public Point(int x, int y)                 ///매개변수 없이 생성자 선언 불가능 - 매개변수 없는 생성자가 자동으로 정의됨
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 10;

            Console.WriteLine(p.x);                 /// x 초기화(구조체 member를 초기화) - 이 부분이 없다면 오류 발생 p405 ???????????
            Console.WriteLine(p.y);                 /// y 초기화 
        }
    }





    internal class p405
    {
    }
}
