using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///   2-2) Hiding - method

namespace Book.Ch07
{


    class Program6
    {
        class Parent
        {
            public void Method() { Console.WriteLine("부모의 메서드"); }
        }

        class Child : Parent
        {
            public void Method() { Console.WriteLine("자식의 메서드"); }

            /// Method 빗금 : 'Child.Method()는 상속된 Parent.Method() 멤버를 숨깁니다. 숨기려면 new 키워드를 사용하세요.'
            ///    
            /// 
            ///  - Method는 (variable과 다르게) 충돌시, 하이딩/오버라이딩을 결정할 수 있다.
            ///  ex Hiding      :  public new void Method(){}                  
            ///     Overriding  :  public virtual / override void Method(){}   
        }

        static void Main1(string[] args)
        {
            Child c1 = new Child();
            c1.Method();
            ((Parent)c1).Method();

        }

        internal class p359__
        {


        }
    }







}
