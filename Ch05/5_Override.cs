using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  날 짜 : 2022/06/09
 *  이 름 : 최희원
 *  내 용 : Override  (p225)
 * 
 *   Hide : 같은 이름으로 멤버를 만들어 모클래스의 멤버를 숨김.
 *  
 *   Overload : 동일 이름을 사용해서 method를 여러개 만듬.
 * 
 *   Overrride : 모class에 있는 method를 식class에서 재정의(식클래스로 덮어씌움).
 *               Overrride를 통해 다형성을 실현한다.
 */

///  AAA
///  method1()
///  method2()
///  method3()
///  |
///  BBB
///  method1()
///  method2()
///  method3()
///  |
///  CCC
///  method1()
///  method2()
///  method3()
///  

namespace Ch05
{
    class AAA
    {
        public void Method1()
        { Console.WriteLine("AAA::Method1..."); }

        public virtual void Method2()                       /// virtual
        { Console.WriteLine("AAA::Method2..."); }

        public virtual void Method3()                       /// virtual
        { Console.WriteLine("AAA::Method3..."); }
    }

    class BBB : AAA
    {
        public new void Method1()                     /// Hiding : BBB의 Method1이 AAA의 Method1을 숨김
        { Console.WriteLine("BBB::Method1..."); }
        
        public override void Method2()                /// Override : BBB의 Method2가 AAA의 Method2를 덮어씌움
        { Console.WriteLine("BBB::Method2..."); }
        
        public void Method3(int a)                    /// Overload : BBB의 Method3와 AAA의 Method3이 매개변수로 구분
        { Console.WriteLine("BBB::Method3..."); }
    }

    class CCC : BBB
    {
        public new void Method1()                           /// Method Hiding : CCC의 Method1이 BBB의 Method1을 숨김
        { Console.WriteLine("CCC::Method1..."); }

        public override void Method2()                     /// Method Override : CCC의 Method2가 BBB의 Method2를 덮어씌움
        { Console.WriteLine("CCC::Method2..."); }

        public override void Method3()                    /// Method Override : CCC의 Method3이 AAA의 Method3을 덮어씌움
        { Console.WriteLine("CCC::Method3..."); }
    }


    internal class _5_Override
    {
        static void Main1(string[] args)
        {

            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();

            b.Method1();
            b.Method2();
            b.Method3();
            Console.WriteLine();

            c.Method1();
            c.Method2();
            c.Method3();
            c.Method3(1);
            Console.WriteLine();



        }
    }
}
