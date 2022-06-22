using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 
///       Value (값)       : 원래 값을 복사하여 안전하지만 메모리 용량이 늘어난다. 원래 값이 보존된다.
///                          기본 자료형(Primitive Type : int, float etc)이 들어있다.
///       Reference (참조) : 복사하지 않고 직접 참조하기에 빠르지만 원래 값이 영향을 받게 된다. 
///                          class로 만들어진 object에 reference가 들어있다.
/// 



namespace Book.Ch06
{
    internal class p301_305
    {
        /// 3-1 Value 복사
        static void Change(int input) { input = 20; }



        /// 4-1 Reference 복사
        class Test { public int value = 10; }
        static void Change2(Test input) { input.value = 20; }
        






        static void Main1(string[] args)
        {
            /// P301
            /// 1 기본 자료형 : 변수 a = 10이라는 값이 memory에 저장(4byte)된다. 
            int a = 10;        


            /// 2 Object 선언 : new Random() instance가 Heap에 위치를 잡고 변수 r에 memory 위치를 나타내는 reference가 저장된다.
            Random r = new Random();




            ///3-1 Value 복사    (p302 - 303)
            int b = 10;
            Change(b);
            Console.WriteLine(b);
            Console.WriteLine();


            ///3-2    
            int c = 10;
            int input = c;
            input = 20;
            Console.WriteLine(c);
            Console.WriteLine();



            ///4-1 reference 복사 (p303-305)
            Test t = new Test();
            t.value = 10;
            Change2(t);
            Console.WriteLine(t.value);
            Console.WriteLine();

            ///4-2 
            Test tA = new Test();
            Test tB = tA;
            tA.value = 10;
            tB.value = 20;
            Console.WriteLine(tA.value);





        }




    }
}
