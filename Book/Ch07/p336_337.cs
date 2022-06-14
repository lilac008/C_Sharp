using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  접근제한자         내부class   외부class   파생class  프로젝트
///  public                o            o           o        o
///  internal              o            o           o        
///  protected internal    o  (같은 어셈블리 안에)   o               - 사용 클래스가 같은 어셈블리 안에 있을때만 접근 가능
///  protected             o                        o
///  private               o

namespace Book.Ch07
{


    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
    }

    class Dog : Animal                                ///Animal에서 상속
    {
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("왈왈");
        }

        public void Test()
        {
            Eat();
            Sleep();
        }

        ///Dog d1 = new Dog();
        ///dog.         


        ///this. - 자식 클래스
        ///base. - 모 클래스

    }

    class Cat : Animal                              ///Animal에서 상속
    {
        public void Meow() { Console.WriteLine("냥냥"); }
    }




    internal class p336_337
    {










    }
}
