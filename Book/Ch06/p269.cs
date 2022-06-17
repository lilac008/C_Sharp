using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  public   dataType   method-name(dType 변수, dType 변수)
///  {
///         dType  output-name  =  initial-value;
///         
///         return output-name;
///  }
///  

/// 반환형 :      void - 처리만 하고, 아무것도 반환하지 않을 때 void를 입력한다.




namespace Book.Ch06
{

    class Ch06_4
    {
        class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        static void Main1(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.Sum(1, 100));
        }



    }

    internal class p269
    {
    }
}
