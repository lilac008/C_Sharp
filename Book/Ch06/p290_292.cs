using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    Constant(상수) : 상수로 선언된 변수는 값을 변경할 수 없음 


namespace Book.Ch06
{
    internal class p290_292
    {


        /// 2. Constant 키워드
        class MyMath
        {
            public const double PI = 3.141592;         /// const가 붙는다.   (ex) Math.PI - 속성이 const double Math.PI : 3.141592....로 선언되어 있다)
        }


        /// 4. Readonly(읽기전용) 키워드 : 선언 시점과, 생성자에서만 변수를 변경할 수 있다.   
        class Product
        {
            private static int count;
            public readonly int id;///              
            public string name;
            public int price;

            public Product(string name, int price)
            {
                id = count++;///
                this.name = name;
                this.price = price;
            }

            Product p = new Product("이름", 100);
            ///Product.id = 10;                        /// 선언 시점, 생성자 외에는 전부 readonly field(읽기전용 필드)로 형성된다.
        }



        static void Main1(string[] args)
        {
            /// 1.Constant(상수)

            ///Math.PI = 20;                          /// 오류 - Constant로 선언된 변수는 값을 변경할 수 없다.

            int r = 10;
            Console.WriteLine("원 둘레 : " + (2 * Math.PI * r));
            Console.WriteLine("원 넓이 : " + (Math.PI * r * r));


            Console.WriteLine();


            /// 3.method 내부에서의 Constant 
            const int v = 10;
            Console.WriteLine(v);







        }


    }
}
