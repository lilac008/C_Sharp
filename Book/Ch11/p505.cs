using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     이름있는 Delegate 형식 : 
/// 
///     접근제한자 - delegate - 반환형 - delegateName([매개변수]);    //delegate class의 상속을 받는 class를 선언
///
/// 
/// 
///

namespace Book.Ch11
{
    public delegate void Test1();               /// delegate 생성 위치 (class 외부)

    internal class p505
    {
        public delegate void Test2();          /// delegate 생성 위치 (class 내부)

        public delegate void TestDelegate();

        static void Main(string[] args)
        {
            Test1 d1;                            /// delegate 자료형으로 변수 선언
            Test2 d2;                            /// delegate 자료형으로 변수 선언


            TestDelegate dA = TestMethod;              ///1) 메서드 이름을 사용한 초기화
            TestDelegate dB = delegate () { };         ///2) 무명 대리자를 사용한 초기화
            TestDelegate dC = () => { };               ///3) lamda를 사용한 초기화

            dA();                                      ///대리자는 일반 method처럼 호출이 가능
            dB();
            dC();
        }

        static void TestMethod() { }


    }
}
