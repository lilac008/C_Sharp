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
///     Generic : class 내부 변수의 타입을 동적으로 일반화시킴. class의 범용성을 갖도록 활용.
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
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();
            box1.Fruit = apple;                                /// set 호출, 초기화 (생성자로 초기화한 것이 아님)
            box1.Fruit.show();                                 /// get 호출, 초기화

            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = banana;
            box2.Fruit.show();









        }
    }
}
