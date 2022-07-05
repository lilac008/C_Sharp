using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     날짜 : 2022/06/13
///     이름 : 최희원
///     내용: Abstract Class (p230)
///
///
///     Class : object의 설계도
///
///     Abstract Class : - 공통 기능은 하나의 method로 구현하고, 개별 기능은 상속 받아 override method로 구현시키는 abstract method를 갖는 class. 오직 상속을 목적으로 설계된다.
///                      - 구체적 내용보다 '기본 속성적과 필요한 method의 형태(프로토 타입)'만 기술하고 세부적 구현은 식class에서 담당
///                      - Abstract Class와 인터페이스는 객체지향 개념을 실제 프로그램 개발에 쉽게 적용하고 유연한 설계를 지원하는 요소                 
///                      - Abstract Class에서는 object 생성이 불가능하다.



namespace Ch06
{
    internal class _1_AbstractClass
    {
        static void Main1(string[] args)
        {
            /// Abstract class는 object 생성이 되지 않는다.
            /// Car car = new Car();


            /// 다형성 적용
            Car s = new Sedan("그랜저", "검정색", 0, 2000);
            Car t = new Truck("포터", "파란색", 0, 1);

            s.SpeedUp(100);
            s.SpeedDown(20);
            s.Show();
            Console.WriteLine();

            t.SpeedUp(80);
            t.SpeedDown(10);
            t.Show();
            Console.WriteLine();
        }

    }
}
