using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     날짜 : 2022/06/14
///     이름 : 최희원
///     내용 : Generic (p395)
///
///     Generic : 데이터 형식에 의존하지 않고, 하나의 값이 여러 다른 데이터 타입들을 가질 수 있는 기술에 중점을 두어 재사용성을 높일 수 있는 프로그래밍 방식
///               class 내부 변수의 타입을 동적으로 일반화(generalization)시킴.
///               class, interface, method 등의 타입을 매개변수로 사용할 수 있게 해주는 역할.
///                         


namespace Ch06
{
    class FruitBox<T>
    {
        private T fruit;

        public T Fruit                         /// Get, Set
        {
            get { return fruit; }
            set { fruit = value; }
        }
    }



    internal class _4_Generic
    {
        static void Main1(string[] args)
        {
            Apple a = new Apple("한국", 3000);
            Banana b = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();
            box1.Fruit = a;                                    /// set 호출, 초기화 (생성자로 초기화한 것이 아님)
            box1.Fruit.show();                                 /// get 호출, 초기화

            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = b;
            box2.Fruit.show();









        }
    }
}
