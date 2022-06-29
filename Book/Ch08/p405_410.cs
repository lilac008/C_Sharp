using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///   Struct (구조체) : 간단한 object를 만들 때 사용하는 형식. 
///                     Class와 거의 동일하나 Class보다 안정성이 높다. (단, 상속 불가, Interface 불가) 
///
///                     1. new 없이 instance생성시 변수 반드시 초기화
///                     2. struct Constructor 선언시 parameter 필수 (parameter없는 생성자가 자동적으로 정의되기 때문에 parameter없이 선언 불가)
///                     - struct 내부 변수는 해당 자료형의 기본값으로 초기화(숫자:0,문자열:null)
///                     4.
///     


///   int : readonly struct System.Int32  
///                                 └(부호있는) 32비트 정수


namespace Book.Ch08
{

    class Ch08_7
    {
        ///2
        struct PointB                                  /// struct 
        {
            public int x;
            public int y;

            ///public PointB() { }                     /// struct 생성자 : parameter없이 선언 불가 (parameter없는 생성자가 자동적으로 정의되기 때문에 parameter없이 선언 불가)
        }


        ///1 
        struct Point                            
        {
            public int x;
            public int y;

            public Point(int x, int y)              
            {
                this.x = x;
                this.y = y;
            }

        }


        ///3  
        struct PointC 
        {
            public int x;
            public int y;

            public PointC(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        ///4  
        struct PointD
        {
            public int x;                                       /// member변수 - 생성자에서 반드시 초기화
            public int y;
            public string testA;
            public string testB;
            ///public string testC = "initialization";         ///선언과 동시에 초기화 불가

            public PointD(int x, int y)             
            {
                this.x = x;                                   ///초기화 
                this.y = y;
                this.testA = "testA";                 
                this.testB = "testB";               

            }
        }

        ///5 
        struct PointE 
        {
            public int x;                                       /// struct 내부 변수를 member변수 선언
            public int y;
            public string testA;
            public string testB;
            public Ch08_7 testC;                               /// class instance를 member변수로 선언

            public PointE(int x, int y)                        ///생성자 overloading
            {
                this.x = x;                           
                this.y = y;
                this.testA = "testA";                    
                this.testB = "testB";
                this.testC = null;
            }

            public PointE(int x, int y, string test)           ///생성자 overloading
            {
                this.x = x;                                   
                this.y = y;
                this.testA = test;                              
                this.testB = test;
                this.testC = null;
            }


        }



        static void Main1(string[] args)
        {
            ///2-1 
            PointB p2 = new PointB();                /// parameter 없는 생성자 



            ///1-1
            Point p;                                  /// struct에서 new 없이 instance생성시
            p.x = 10;                                 /// struct변수 반드시 초기화 (없애면 cw출력에서 오류)
            p.y = 10;                                 /// struct변수 반드시 초기화 

            Console.WriteLine(p.x);                   /// 10         
            Console.WriteLine(p.y);                   /// 10






            ///3
            PointC p3 = new PointC();               /// parameter 없는 생성자 

            Console.WriteLine(p3.x);                /// 0
            Console.WriteLine(p3.y);                /// 0

            

        }
    }





    internal class p405_410
    {
    }
}
