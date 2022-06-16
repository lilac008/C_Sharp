using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   다형성 : 중복 방지를 위해 하나의 클래스가 여러 형태로 변환. 자식 클래스가 모 클래스로 위장
///
///

namespace Book.Ch07
{
    internal class p340
    {
        class Animal
        {
            public int Age { get; set; }
            public Animal() { this.Age = 0; }
            public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠잡니다"); }
        }

        class Dog : Animal
        {
            public string Color { get; set; }
            public void Bark() { Console.WriteLine("왈왈"); }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("야옹야옹"); }
        }



        static void Main1(string[] args)
        {


            List<Dog> d1 = new List<Dog>() { new Dog(), new Dog(), new Dog() };    //비슷한 코드 중복
            List<Cat> c1 = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in d1)                                               //비슷한 코드 중복
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            Console.WriteLine();

            foreach (var item in c1)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            Console.WriteLine();









        }



    }
}
