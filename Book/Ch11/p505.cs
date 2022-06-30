using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Delegate :  (무명 deligate와 다르니 주의!!)
///     
///     접근제한자 - delegate - 반환형 - delegateName( 매개변수 );    -  delegate class의 상속을 받는 class를 선언
///     



namespace Book.Ch11
{
    public delegate void TestA();                        /// class 외부에 delegate 선언


    internal class p505
    {
        public delegate void TestB();                   /// class 내부에 delegate 선언






        static void Main1(string[] args)
        {
            TestA dA;                                   /// delegate자료형    변수;  선언
            TestB dB;


            TestB d1 = Method_N;                       ///1) method명을 이용한 초기화
            TestB d2 = delegate () { };                ///2) 무명 deligate를 사용한 초기화
            TestB d3 = () => { };                      ///3) lamda(익명 deligate)를 사용한 초기화

            d1();                                      ///deligate는 일반 method처럼 호출이 가능
            d2();
            d3();
        }

        static void Method_N() 
        { 
        }


    }
}
