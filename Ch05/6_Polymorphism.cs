using Ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// 날짜 : 2022/06/09
/// 이름 : 최희원
/// 내용 : Polymorphism(다형성) p340
/// 
/// 
///   Polymorphism : override를 활용해 모클래스의 기능이 자식클래스에서 여러 기능으로 변함. (하나의 모class가 여러 형태로 변환)
///                 - object의 타입선언을 모클래스로 선언
///
///
/// 母 Animal
///  move();
///   run
///
/// 子 Tiger   子 Eagle   子 Shark
/// move();     move();   move();
/// run         fly       swim
///


namespace Ch05
{
    internal class _6_Polymorphism
    {
        static void Main1(string[] args)
        {
            /// Polymorphism을 적용한 object 생성
            Animal a1 = new Tiger();                     ///Tiger t = new Tiger(); 의 바뀐 형태
            Animal a2 = new Eagle();                     
            Animal a3 = new Shark();

            a1.Move();
            a2.Move();
            a3.Move();


            /// object type 캐스팅 (Animal Hunt가 없을시)
            Tiger t = (Tiger)a1;
            Eagle e = (Eagle)a2;
            Shark s = (Shark)a3;

            //Tiger t = a1 as Tiger;                  /// (Tiger)a1; 의 바뀐 형태
            //Eagle e = a2 as Eagle;                  /// (Eagle)a2; 의 바뀐 형태
            //Shark s = a3 as Shark;                  /// (shark)a3; 의 바뀐 형태

            t.Hunt();
            e.Hunt();
            s.Hunt();
            Console.WriteLine();


            /// object type 확인
            if (a1 is Tiger)                               
            { Console.WriteLine("a1은 Tiger Class입니다."); }

            if (a2 is Eagle)
            { Console.WriteLine("a2은 Eagle Class입니다."); }

            if (a3 is Shark)
            { Console.WriteLine("a3은 Shark Class입니다."); }











        }

    }
}
