using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{

    class First
    {
    }

    class Second
    {
    }

    class Third
    {
        class Fourth
        {
        }

        class Fifth
        {
        }

        //class Math     -   오류 : 아래  기존의 존재하는 Math. class member들과 이름이 겹치면 충돌해 오류가 난다.
        //{ 
        //}

        static void Main1(string[] args)
        {
            // 위에서 만들어진 class 확인하는 법      
            //
            /// First     - 위에 class First가 생성되었으므로 껍데기만 있지만 초록 글씨로 나오는 것을 확인.



            // Class 생성 (마우스 없이)     
            //
            /// ClassName v1 = new ClassName();    //ctrl+. -  ClassName 형식 생성 - 새 파일에서 ClassName 생성. 



            Console.WriteLine(Math.Abs(-10));
        }
    }


    internal class p219_224
    {
    }
}
