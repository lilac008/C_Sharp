using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///   Interface : class와 동급의 카테고리. class를 생성하는 위치라면 어디든지 생성 가능.
///                clss이름이 겹치는 걸 방지하고자 다중 상속을 금지하고 하나의 클래스만 상속받을 수 있게 했으나, interface를 사용한 다중 상속은 허용한다.
/// 
/// 
/// 


namespace Book.Ch09
{
    internal class p433_438
    {
        ///  다른 파일에 interface 생성 : 추가 - 새항목 - 인터페이스
        ///  같은 파일에 interface 생성 : 아래 참조  
        /// 
        interface IBasic
        {
            int TestInstanceMethod();              ///method에 내부구현을 입력할 수 없다   ??????? 
            int TestProperty { get; set; }         ///속성에도 내부 구현을 입력할 수 없다   ??????
        }

        class TestClass : IBasic               /// IBasic 빗금 : Ctrl. - interface 구현
        {
            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }

            public int TestProperty
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }


        }

        static void Main1(string[] args)
        {
            IBasic b = new TestClass();                   ///interface 상속 - 다형성 구현, 다중상속(하나의 클래스가 여러 부모클래스를 갖는것) 구현

        }





    }
}
