using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p342_343
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

            ///다형성 - 코드 중복 해결
            List<Animal> a1 = new List<Animal>() { new Dog(), new Cat(), new Cat(), new Dog() };


            foreach (var item in a1)
            {
                item.Eat();
                item.Sleep();

                
                ///((Dog)item).
                ///((Cat)item).
                ///((Dog)item).Bark();   오류
                ///((Cat)item).Meow();   오류

                Console.WriteLine();

            }
            Console.WriteLine();

        }




    }
}
