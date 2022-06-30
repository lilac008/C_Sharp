using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///  날 짜 : 2022/06/21
///  이 름 : 최희원
///  내 용 : Delegate(대리자) (p493)
///  
/// 
/// 
///    Delegate  :  method에 대한 참조를 나타내는 형식으로 method를 대신 호출해주는 역할, method의 매개변수
///                 대리자를 익명 method로 많이 활용한다.
/// 
///                  Delegate / Lamda : method(행위)를 저장하고 전달, method(행위)를 변수로 사용하는 것.  
///                  


namespace Ch09
{
    internal class _1_Delegate
    {
        public delegate int MyDelegate(int x, int y);                          ///  Delegate 선언 
        public delegate int SumDelegate(int[] arr);                            


        public static int Plus(int x, int y)                                 /// 1-1. 
        { return x + y; }

        public static int Minus(int x, int y)
        { return x - y; }

        public static int OddSum(int[] arr)                                  /// 1-5
        {
            int sum = 0;
            foreach (int n in arr)
            {
                if (n % 2 == 1) { sum += n; }
            }
        }

        public static int EvenSum(int[] arr)
        {
            int sum = 0;
            foreach (int n in arr)
            {
                if (n % 2 == 0) { sum += n; }
            }
        }

        public static int Sum(int[] arr, SumDelegate sumDelegate)             /// 1-7.
        { return sumDelegate(arr); }



        static void Main1(string[] args)
        {

            MyDelegate my1 = new MyDelegate(Plus);                      /// 1-3. 대리자 초기화
            MyDelegate my2 = new MyDelegate(Minus);


            int r1 = my1(1, 2);                                         ///  1-4. 대리자 실행
            int r2 = my2(2, 3);
            Console.WriteLine(r1);
            Console.WriteLine(r2);


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };                    /// 1-8 대리자 활용 : method 매개변수로 대리자 선언

            int rs1 = Sum(arr, OddSum);                                       /// 행위(메서드)를 전달하기 위해 대리자 사용                        
            int rs2 = Sum(arr, EvenSum);


            var md = delegate (int x, int y)                                  /// 1-9 대리자를 익명 method로 활용
            { return x * y; };

            int result1 = md(2, 3);
            int result2 = md(3, 4);
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            List<int> dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  /// 1-10. 익명method를 매개변수로 갖는 컬렉션 method

            dataset.ForEach(delegate (int n)                                     ///ForEach 1~10반복
            { Console.WriteLine(n + " "); });

            foreach (int n in dataset)
            { Console.WriteLine(n + " "); }
        }

    }
}
