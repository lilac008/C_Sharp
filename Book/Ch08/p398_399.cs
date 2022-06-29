using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Array    : method       /    array[i]  
///     List     : Class        /     list[i] 
///     Indexer  : Class      /    this[dT V]


namespace Book.Ch08
{

    internal class p398_399
    {
        ///1
        class Products
        {
            public int this[int i_]                               /// this[int i]로 indexer선언      
            {
                get { return i_; }                                /// p[i_]를 출력할 때 호출 (자료형 : int)
                set { Console.WriteLine(i_ + "번째 상품 설정"); }  
            }
        }

        ///2
        class SquareCalculator
        {
            public int this[int i]
            {
                get { return i * i; } 
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                ///1-1
                Products p = new Products();
                Console.WriteLine(p[1]);


                ///2-1
                SquareCalculator a = new SquareCalculator();
                Console.WriteLine(a[10]);
                Console.WriteLine(a[20]);
                Console.WriteLine(a[30]);
            }
        }


    }



}
