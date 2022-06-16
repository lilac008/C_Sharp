using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///       Shadowing   : 특정 영역에서 이름이 겹쳐 가장 가까운 변수를 가르키는 것
///                     어떤 대상이 shdowing되면 (일반적인 방법으로) 가려진 변수에 접근할 수 없다
///                     
///        Hiding     : 모class와 식class에 동일한 이름의 member(variable, method전체)가 있을 때, 정상적인 상속을 막고, 가장 가까운 변수를 가르키는 것
///                   - new (method)   
///                 
///       Overriding  : 모class와 식class에 동일한 이름의 method가 있을 때, 식의 method가 모의 method를 덮어씌운다. (기존의) 모의 method는 호출해도 (다시 재정의한) 식의 method로 나타난다.
///                     overriding은 method에서만 일어나며, overriding외에는 이름 재사용 비추..    
///                    - virtual / override (method)
///        
/// 
///       Overloading : 같은 이름의 method를 여러개 만드는 것
///       


///         Shadowing
///         

namespace Book.Ch07
{
    class Program4
    {
        public static int sameV = 10;          ///static variable 선언 : static method 내부에서 사용할 수있도록 

        static void Main1(string[] args)       ///static method
        {
            int sameV = 20;
            Console.WriteLine(sameV);

        }


        internal class p357
        {




        }
    }







}
