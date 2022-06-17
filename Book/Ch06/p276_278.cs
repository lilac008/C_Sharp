using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///          Overloading  :  이름이 같으나 매개 변수는 다른 method를 만드는 것 (반환값이 다르다고 해서 overloading이 일어나지는 않는다.)
///          
///                          ex) Math.Abs()      // 같은 method에 decimal, float, double, int 등 매개변수의 형태가 다르다.



namespace Book.Ch06
{

    class Ch06_8
    {

        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }


            static void Main1(string[] args)
            {

                ///int
                Console.WriteLine(MyMath.Abs(52));
                Console.WriteLine(MyMath.Abs(-273));
                Console.WriteLine();

                ///double
                Console.WriteLine(MyMath.Abs(52.273));
                Console.WriteLine(MyMath.Abs(-32.103));
                Console.WriteLine();

                ///long
                Console.WriteLine(MyMath.Abs(21474836470));
                Console.WriteLine(MyMath.Abs(-21474836470));
                Console.WriteLine();

                ///MyMath.Abs()                                        /// 3개의 method가 overloading 된다. 
            }
        }


        /// Overloading 오류 : method를 호출할 때 어떤 method를 호출할지 정확히 알 수 없음.  
        //class TestWorld 
        //{
        //     public int Test(int input) { }             /// Ch06_8.TestWorld.Test 형식은 동일한 매개 변수 형식을 가진 'Test' 멤버를 미리 정의합니다.
        //     public double Test(int input) { }
        //     public double Test(int input) { }
        //}
    }


    internal class p276_278
    {
    }
}
