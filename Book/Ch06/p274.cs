using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    ///
    ///          static
    ///          
    ///          static   +   instance V, instance M    =   class Variable, class Method  

    class Ch06_7
    {

        public static int instanceV = 10;               ///class method에서 instance 변수 사용은 오류가 발생. static이 없으면 오류



        static void Main1(string[] args)
        {
            Console.WriteLine(instanceV);
        }


    }



    internal class p274
    {
    }
}
