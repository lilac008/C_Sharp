using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p346_350
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
            List<Animal> a1 = new List<Animal>() { new Dog(), new Cat() };


            foreach (var item in a1)
            {
                item.Eat();
                item.Sleep();

                //is - Object is Class
                if (item is Dog) { ((Dog)item).Bark(); }        ///변수 item이 Dog/Cat Class 라면
                if (item is Cat) { ((Cat)item).Meow(); }
                Console.WriteLine();


                //as - 변환에 실패해도 null(아무것도 아닌 값)으로 남음
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Cat) { (item as Cat).Meow(); }
                Console.WriteLine();


                // as - 
                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
                Console.WriteLine();

            }
            Console.WriteLine();

        }







    }
}
