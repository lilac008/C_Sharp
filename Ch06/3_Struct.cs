using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     날짜 : 2022/06/14
///     이름 : 최희원
///     내용 : Struct (구조체) (p404)
///
///     Struct : 간단하게 object를 만들 때 사용하는 형식, class와 동일하지만 몇 가지 제한
///              상속 x, 캡슐화x


namespace Ch06
{
    struct MyPoint                      /// struct MyPoint : Object
    {
        public int x;
        public int y;


        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()    /// ToString() method - field 출력
        {
            return String.Format($"  x : {x},  y : {y}  ");
        }
    }


    internal class _3_Struct
    {
        static void Main1(string[] args)
        {

            MyPoint mp;
            mp.x = 10;
            mp.y = 20;

            Console.WriteLine("p1 : " + mp.ToString());

            MyPoint mp2 = new MyPoint(20, 30);
            Console.WriteLine("p2 : " + mp2.ToString());


        }
    }
}
