using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
///     날짜 : 2022/06/08
///     이름 : 최희원    
///     내용 : class variable, class method   (p225)
///
///     Class variable, Class method : - static 변수, Data영역 메모리 공간에 하나의 class로 관리
///                                   - class Type(객체 생성x)으로 직접 참조
///                                   
///     Singleton object : 하나의 instance만 생성할 수 있으며 하나의 instance로 공유한다.
///                        - 메모리 절약, 성능 향상


namespace Ch05
{
    class Increment
    {
        public int num1;                                           ///num1 = 0; 생략
        public static int num2;                                    ///num2 = 0; 생략



        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1 : {0}, num2 : {1}", num1, num2);
        }

        public static void Add()                                  ///static 선언 : 따로 변수를 지정할 필요없이 전체 다 static(정적) 지정
        {
            ///num1++;                                           /// staic method(class method)에서는 non-static 변수를 참조할 수 없다.
            num2++;

            Console.WriteLine("num2 : " + num2);
        }
    }


    internal class _3_Static
    {
        static void Main1(string[] args)
        {

            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();


            /// class variable, class method 실행
            Increment.num2 = 10;                        ///object 생성 없이 바로 num2 출력 가능.
            Increment.Add();


            /// Sbu3 - Car object
            Car car1 = new Car("현대차", "검은색", 0);
            Car car2 = new Car("기아차", "흰색", 0);
            Car car3 = new Car("폭스바겐", "검은색", 0);

            car1.Show();
            car2.Show();
            car3.Show();


            /// Sbu3 - Calc singleton object 
            Calc c1 = Calc.Instance;              ///Calc c1 = new Calc();에서 Calc 싱글톤 객체로 (메모리 아끼기)
            Calc c2 = Calc.Instance;              ///Calc c2 = new Calc();에서 Calc 싱글톤 객체로 (메모리 아끼기)
            Calc c3 = Calc.Instance;
            Calc c4 = Calc.Instance;

            int r1 = c1.Plus(1, 2);
            int r2 = c2.Minus(1, 2);
            int r3 = c3.Multi(2, 3);
            int r4 = c4.Div(4, 2);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);













        }

    }
    




}
