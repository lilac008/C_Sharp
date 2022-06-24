using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///    Interface : 이러한 최소사항을 지켜서 만들면 나머지는 알아서 처리해주겠다는 규약. 특별한 기능x   
/// 
///    IComparable Interface : 
///    IDisposable Interface : using 블록을 사용할 때에 자동으로 호출되는 규약
///                            C#의 interface는 method호출, 키워드 사용할 때 사용된다.
/// 
/// 


namespace Book.Ch09
{
    internal class p430_432
    {

        class Dummy : IDisposable
        {
            public void Dispose()                  /// IDisposable의 interface구현
            {
                Console.WriteLine("Dispose()를 호출");
            }
        }


        static void Main1(string[] args)
        {
            Dummy d = new Dummy();
            d.Dispose();                           ///Dispose() method 구현


            using (Dummy d2 = new Dummy())         /// using keyword  : IDispose()는 using 블록이라는 기능을 사용할 때 자동으로 호출되는 기능
            {                                      ///                  C#은 using 블록의 괄호 내에서 생성한 클래스가 IDisposable interface의 상속을 받을경우, using블록을 벗어날 때 자동으로 Dispose() method를 호출한다. 코드를 실행하면 Dispose()를 따로 호출하지 않아도 실행된다.

            }

        }




    }
}
