using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  접근제한자         내부class   외부class   파생class  프로젝트
///  public                o            o           o        o
///  internal              o            o           o        
///  protected internal    o  (같은 어셈블리만)   o               - 사용 클래스가 같은 어셈블리 안에 있을때만 접근 가능
///  protected             o                        o
///  private               o


namespace Book.Ch07
{
    internal class p339__
    {
        class Animal1
        {
            private void Private { }
            protected void Protected { }
            public void Public { }

            public void TestA()
            {
                Private();                 ///자신의 클래스 내부 : 모든 멤버 사용 가능
                Protected();
                Public();
            }
        }

        class Dog1 : Animal1
        {
            public void TestB()
            {
                Protected();              ///상속받은 클래스 : private은 사용 불가
                Public();
            }
        }



        internal class p339
        {
            static void Main1(string[] args)
            {
                Dog d1 = new Dog();
                dog.Public();           /// 이 외의 모든 곳 : public만 사용 가능
            }
        }




    }
}
