using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Deligate  : method라는 행위를 변수처럼 활용. 즉 method 자체를 매개변수로 전달하거나 반환하거나 연산자로 활용.
///                (method = 행위 , variable = data/value ) 
///    Lamda     : delegate를 조금 더 짧게 사용하는 것
/// 
/// 
/// 
///    Deligate는 일종의 클래스 선언  
///             ex) class TestClass{}
///                 TestClass t = new TestClass()
///
///                 delegate void TestDelegate();
///                 TestDelegate t1 = <methodName, 무명Deligate, Lamda> : Delegate 변수를 초기화하는 방법



 
///         Delegate 형식 : 
/// 
///         접근제한자 - delegate - 반환형 - delegateName([매개변수]);    //delegate class의 상속을 받는 클래스를 선언
///
/// 
/// 
///

namespace Book.Ch11
{
    public delegate void TestDelegate1();               /// delegate 생성 위치 (class 외부)

    internal class p505
    {
        public delegate void TestDelegate2();          /// delegate 생성 위치 (class 내부)



        public delegate void TestDelegate();

        static void Main(string[] args)
        {
            TestDelegate1 d1;                         /// 새로 선언한 delegate 자료형으로 변수 선언
            TestDelegate2 d2;                         /// 새로 선언한 delegate 자료형으로 변수 선언


            TestDelegate A = TestMethod;              ///Method 이름을 사용한 초기화
            TestDelegate B = delegate () { };         ///무명 delegate를 사용한 초기화
            TestDelegate C = () => { };               ///lamda를 사용한 초기화

            A();                                      ///일반 method처럼 호출
            B();
            C();
        }

        static void TestMethod() { }


    }
}
