using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///         abstract : 절대 상속 or 절대 overriding. 
///                    (추상, 틀만 잡아놓아서) 객체 생성 불가.
///            
///                    1) class에 올 경우
///                    2) method에 올 경우 (해당 method가 포함된 class도 자동적으로 abstract이 된다)


namespace Book.Ch07
{

    class Program14
    {
        abstract class Parent
        {
            public void Test() { }
        }

        class Child : Parent
        {
            public void Test() { }
        }

        static void Main1(string[] args)
        {
            ///Parent p1 = new Parent();      //인스턴스 오류 (추상 형식 또는 인터페이스 'Program.Parent'의 인스턴스를 만들 수 없습니다.)
            ///Child c1 = new Child();

            ///p1.Test();
            ///c1.Test();
        }


    }


    internal class p371__
    {
    }
}
