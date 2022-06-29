using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Generic : class 내부 자료형에 별칭(식별자 T를 사용)을 지정. 내부 변수의 타입을 동적으로 일반화시키는 문법.



namespace Book.Ch08
{
    class Ch08_1
    {

        class Wanted<T>                 
        {
            public T Value;                                /// 변수
            public Wanted(T value)                         /// 매개변수
            {
                this.Value = value;
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Wanted<string> w1  = new Wanted<string>("String");
                Wanted<int>    w2  = new Wanted<int>(52273);
                Wanted<double> w3  = new Wanted<double>(52.273);

                Console.WriteLine(w1.Value);              ///"String"
                Console.WriteLine(w2.Value);              ///52273
                Console.WriteLine(w3.Value);              ///52.273




            }

        }


    }

    internal class p396
    {
    }


}
