using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///         abstract : 절대 상속 or 절대 overriding. 
///                    (추상, 틀만 잡아놓아서) 객체 생성 불가.
///            
///                    1) class에 올 경우
///                    2) method에 올 경우 : 해당 method가 포함된 class도 자동적으로 abstract이 된다.


namespace Book.Ch07
{
    class Program15
    {
        abstract class Parent                 /// 2) abstract method가 포함된 class도 자동적으로 abstract이 된다
        {
            public abstract void Test();      /// 1) abstract method가 되면 중괄호{}를 사용하지 않고 곧바로 세미콜론;을 찍는다
        }

        class Child : Parent                  ///(override가 없을 경우) Child에서 오류 - Program15.Child는 상속된 추상 멤버 'Program15.Parent.Test()'를 구현하지 않습니다.
        {
            public override void Test() { }   /// 3) 절대 overriding - virtual없이 abstract만 선언한다. ///절대 상속 - 식 클래스에 반드시 method가 구현되어야 한다.?????????
        }                                     /// 
    }



    internal class p372_373__
    {
    }
}
