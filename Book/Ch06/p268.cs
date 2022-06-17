using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  접근제한자   반환형   method-name(변수)
///  {
///          method-code 
///  }
///  

/// 반환형 :      void - 처리만 하고, 아무것도 반환하지 않을 때 void를 입력한다.


namespace Book.Ch06
{
    class Ch06_3
    {
        class Test
        {
            public void Print()                                         /// void - 반환형
            {
                Console.WriteLine("Print() method가 출력되었습니다.");
            }
        }

        static void Main1(string[] args)
        {
            Test t = new Test();
            t.Print();
            t.Print();
            t.Print();
        }
    }
    internal class p268
    {
    }
}
