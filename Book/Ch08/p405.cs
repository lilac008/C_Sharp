using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   Structor(구조체) : Class와 거의 동일. 간단한 object를 만듬. (단 상속 불가, Interface 불가)


///   int : readonly struct System.Int32  
///                                 └(부호있는) 32비트 정수


namespace Book.Ch08
{

    class Ch08_7
    {
        struct Point                                  /// 구조체
        {
            public int x;
            public int y;


            public Point(int x, int y)                /// 구조체 생성자 : 매개변수 없이 생성자 선언 불가능
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main1(string[] args)
        {
            Point p;                                  /// 구조체 variable;  -  new 키워드 없이 instance 생성
            p.x = 10;                                 /// 초기화 - 없으면 오류
            p.y = 10;                                 /// 초기화 - 없으면 오류

            Console.WriteLine(p.x);                 
            Console.WriteLine(p.y);                
        }
    }





    internal class p405
    {
    }
}
