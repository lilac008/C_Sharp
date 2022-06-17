using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 4-1) Hiding (Overriding 적용 전)

namespace Book.Ch07
{
    class Program9
    {
        class Animal
        {
            public void sameEat() { Console.WriteLine("냠냠 먹습니다"); }             ///같은 이름 -> hiding당하면 모의 method만 출력하게 된다. 
        }

        class Dog : Animal
        {
            public void sameEat() { Console.WriteLine("강아지 사료를 먹습니다"); }    ///같은 이름
        }

        class Cat : Animal
        {
            public void sameEat() { Console.WriteLine("고양이 사료를 먹습니다"); }    ///같은 이름
        }



        static void Main1(string[] args)
        {


            List<Animal> a1 = new List<Animal>()
            { new Dog(), new Cat(), new Cat(), new Dog(), new Dog(), new Cat(), new Dog(), new Dog() };

            foreach (var item in a1)
            {
                item.sameEat();
            }
            Console.WriteLine();

        }
    }



    internal class p364
    {
    }
}
