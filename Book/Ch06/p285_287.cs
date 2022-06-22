using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///     Constructor : instance 생성 시 실행되는 method
///     
/// 
///

namespace Book.Ch06
{
    internal class p285_287
    {
        class Hidden
        {
            private Hidden() { }                       /// 1. private Constructor - 클래스 인스턴스를 만들 수 없게 함. 
        }                                              ///                         1. 정적 멤버만 가지고 있을 때    ex)Math Class - instance를 생성하지 못하게 private 생성자를 정의함, but C#에서는 Math Class도 instnace 생성이 가능/ <summary>
                                                       ///                         2. 팩토리 method(모 class에 숨겨진 식 class의 instance를 만듬)로만 instnace를 생성하게 하고 싶을 때


        class Sample
        {
            public static int value;

            static Sample()                                  /// 2. Static Constructor(정적) : 정적 요소 초기화) : 
            {                                                ///                                    1. 접근제한자, 매개 변수 사용하지 못한다.
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }



        static void Main1(string[] args)                     /// static
        {

            ///Hidden h = new Hidden();                 /// 1-1. 오류 - private constructor로 인해 instnace 생성 불가 



            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);                /// 2-1. 정적 생성자의 호출 시점 : 이때 한번만 호출된다. 해당 class와 관련된 요소는 처음 사용하는 시점에 자동적으로 호출(별도 호출 불가능)   
            Console.WriteLine("두 번째 위치");
            Sample s = new Sample();
            Console.WriteLine("세 번째 위치");
            Console.WriteLine();


            Console.WriteLine("첫 번째 위치");
            ///Sample s = new Sample();                     /// 2-2. 정적 생성자의 호출 시점 : 이때 한번만 호출된다. 해당 class와 관련된 요소는 처음 사용하는 시점에 자동적으로 호출(별도 호출 불가능)    
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
            Console.WriteLine();



        }



    }
}
