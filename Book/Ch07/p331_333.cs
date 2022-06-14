using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p331_333
    {
        class Dog
        {
            public int Age { get; set; }
            public String Color { get; set; }

            public Dog() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
            public void Sleep() { Console.WriteLine("Zzz 잠을 잡니다"); }
            public void Bark() { Console.WriteLine("왈왈"); }
        }

        class Cat
        {
            public int Age { get; set; }

            public Cat() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
            public void Sleep() { Console.WriteLine("zzZ 잠을 잡니다"); }
            public void Meow() { Console.WriteLine("냥냥"); }
        }

        static void Main1(string[] args)                                       //class cat,dog의 instance를 만들고 method실행
        {
            List<Dog> d1 = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> c1 = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in d1)
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

        }




    }
}
