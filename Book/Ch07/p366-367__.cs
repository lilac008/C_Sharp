using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// 4-3) new, virtual, override 적용


namespace Book.Ch07
{
    class Program11
    {
        class Animal
        {
            public virtual void sameEat() { Console.WriteLine("냠냠 먹습니다"); }
        }

        class Dog : Animal
        {
            public new void sameEat() { Console.WriteLine("강아지 사료를 먹습니다♧"); }         /// new -> hiding으로 변경(본인을 숨긴다??) 
        }

        class Cat : Animal
        {
            public override void sameEat() { Console.WriteLine("＊고양이 사료를 먹습니다＊"); }
        }



        static void Main1(string[] args)
        {


            List<Animal> a1 = new List<Animal>()
            { new Dog(), new Cat(), new Cat(), new Dog(), new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in a1)
            {
                item.sameEat();
            }
            Console.WriteLine();

        }
    }




    internal class p366_367
    {
    }
}
