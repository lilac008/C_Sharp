using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   Interface : class와 동급의 카테고리로 class를 생성하는 위치라면 어디든지 생성이 가능하다.
///               class의 이름이 겹치는 걸 방지하고자 하나의 클래스만 상속받을 수 있게 되어있으나, interface는 다중 상속을 허용한다.
/// 


namespace Book.Ch09
{
    internal class p439_441
    {

        class Parent { }

        class Child : Parent, IDisposable, IComparable       /// 직접적으로 Parent 상속, 보조적으로 IDisposable, IComparable interface를 다중상속
        {
            public void Dispose()                           /// IDispose interface
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object? obj)              /// ICompareTo interface
            {
                throw new NotImplementedException();
            }
        }

        static void Main1(string[] args)
        {

            Child c = new Child();
            Parent c1 = new Child();              /// Parent 자료형으로 변환
            IDisposable c2 = new Child();     /// IDisposable 자료형으로 변환
            IComparable c3 = new Child();     /// IComparable 자료형으로 변환

        }





    }
}
