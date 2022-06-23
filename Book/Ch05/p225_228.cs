using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///  variable : method에 정의된 객체 
///  instance : class에 정의된 객체. 소문자가 규칙. (대게 private으로 선언된다.)


///  Access Modifier(접근제한자)
///
///  public     : 모든 접근을 허용
///  protected  : 같은 패키지(폴더)에 있는 객체와 상속관계의 객체들만 허용
///  default    : 같은 패키지(폴더)에 있는 객체들만 허용
///  private    : 현재 object 내에서만 허용
///
///  ex) AccessModifier - dataType - variable;

namespace Book.Ch05
{
    internal class p225_228
    {
        /// Class className
        /// AccessModifier - dataType - instance variable;  
        class User
        {
            public string name;                     /// instance variable 1) 대게 private선언되지만 여기서는 배우지 않아서 public 
            public string password;                 ///                   2) 소문자가 규칙
            public string address;
            public string phoneNumber;
            public DateTime regDate;
        }




        class Program
        {
            class Product ///1,3
            {
                public string name;               /// instance variable
                public int price;
            }

            class Product2 ///2 
            {

                public string name = "오렌지";             /// instance variable 선언과 동시에 초기화(C#에만 有)(p227) 
                public int price = 2222;
            }




            static void Main1(string[] args)
            {
                ///1 main에서 변수 지정
                Product p1 = new Product();                 /// instance variable 생성

                p1.name = "딸기";                           /// instance variable 변경
                p1.price = 1111;

                Console.WriteLine(p1.name);
                Console.WriteLine(p1.price);
                Console.WriteLine(p1.name + " : " + p1.price + "원");
                Console.WriteLine();


                ///2 class에서 변수 지정  
                Product2 p2 = new Product2();
                Console.WriteLine(p2.name);
                Console.WriteLine(p2.price);
                Console.WriteLine(p2.name + " : " + p2.price + "원");
                Console.WriteLine();



                ///3 main에서 변수 지정
                /// ClassName variable = new ClassName(){ 초기화 };
                Product pA = new Product() { name = "키위", price = 3001 };        /// 3001으로 초기화
                Product pB = new Product() { name = "망고", price = 3002 };        /// 3002으로 초기화
                Console.WriteLine(pA.name + ":" + pA.price);
                Console.WriteLine(pB.name + ":" + pB.price);








            }

        }








    }
}
