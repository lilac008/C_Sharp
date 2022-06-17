using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Generic : class 내부 자료형에 별칭을 지정하는 기능.  식별자 T를 사용.
///             : class 내부 변수의 타입을 동적으로 일반화시키는 문법.


namespace Book.Ch08
{
    class Ch08_1
    {

        class Wanted<T>                 ///Generic을 지정할 때는 식별자 T를 사용
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Wanted<string> wString = new Wanted<string>("String");
                Wanted<int> wint = new Wanted<int>(52273);
                Wanted<double> wdouble = new Wanted<double>(52.273);

                Console.WriteLine(wString.Value);
                Console.WriteLine(wint.Value);
                Console.WriteLine(wdouble.Value);




            }

        }


    }

    internal class p396
    {
    }


}
