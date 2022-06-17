using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// 두 개 이상의 Generic <T,U>
/// 

/// new - 객체 생성용 new    / 이름 재사용 new      - p ???????
/// where - 모든 자료형을 허용하면 안 되는 경우 where을 사용해서 Generic을 제한 
///       - 용도 3가지
///       



namespace Book.Ch08
{
    class Ch08_2
    {
        class Test1<T, U>
            where T : class               ///T는 class여야 한다
            where U : struct              ///U는 구조체여야 한다

        { }

        class Test2<T, U>
            where T : IComparable                  ///T는 IComparable 또는 IComparable의 상속을 받은 것
            where U : IComparable, IDisposable     ///U는 IComparable과 IDisposable 또는 이러한 것들의 상속을 받은 것이어야만 한다

        { }


        internal class p397__
        {
        }
    }



    internal class p397
    {
    }
}
