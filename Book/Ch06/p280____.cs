using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///  접근제한자   dataType  variable-name
/// 
///  접근제한자   반환형    method-name(변수)
///  {
///          method-code 
///  }
///  

///     접근제한자
///     private : 입력하지 않으면 자동으로 private이 설정됨. Main() method는 기본적으로 private이다.
///     public 



namespace Book.Ch06
{
    class Ch06_09
    {


        class Test
        {
            public void TestMethod()
            {
                //Program.Main(new string[] { "" });         ///외부 클래스에서 접근
            }

        }

        class Program
        {

            static void Main1(string[] args)
            {

            }
        }
    }



    internal class p280____
    {
    }
}
