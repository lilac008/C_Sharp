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

            ///base.                                ///p338 2)(이름이 겹치거나 하이딩 등의 경우) [this. : 자식 클래스, base. : 모 클래스]로 구분.
        }

        public void Test()
        {
            Eat();                                  ///p338 1) Animal에서 상속받은 Eat(),Sleep() method 호출
            Sleep();
        }

    }

    class Cat : Animal                              ///Animal에서 상속
    {
        public void Meow() { Console.WriteLine("냥냥"); }
    }

    internal class p336_338
    {
        static void Main1(string[] args)
        {
            Dog d1 = new Dog();
            ///d1.                 ///자신, 부모 멤버 모두 접근 가능
        }
    }


}
