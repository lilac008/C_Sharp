using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///  날 짜 : 2022/06/21
///  이 름 : 최희원
///  내 용 : Lamda (p500)
///  
/// 
///   Lamda : 함수적 프로그래밍을 지원하기 위한 문법 식
///           Delegate를 더 편하게 사용하기 위한 간단한 방식 (익명method라고 한다.)
/// 
/// 

namespace Ch09
{
    internal class _2_Lamda
    {
        static void Main1(string[] args)
        {
            /// Func Delegate (반환이 있는 람다식)
            Func<string> f1 = () => { return "f1 실행"; };                      ///var f1 = () => { return "f1 실행"; }; 해도 된다.
            Func<int, string> f2 = (x) => { return "f2 x : " + x; };
            Func<int, int, string> f3 = (x, y) => { return $"f3 x : {x}, y : {y}"; };

            string r1 = f1();
            string r2 = f2(3);
            string r3 = f3(3, 4);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);


            /// Action Delegate (반환이 없는 람다식)
            Action a1 = () => Console.WriteLine("a1 실행");
            Action<int> a2 = (x) => { Console.WriteLine("a2 x : " + x); };
            Action<int, int> a3 = (x, y) => { Console.WriteLine($"a3 x : {x}, y : {y}"); };


            a1();
            a2(3);
            a3(3, 4);


            ///람다식 활용
            List<int> dataset = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            dataset.ForEach((n) => { Console.WriteLine(n + " "); });
        }


    }
}
