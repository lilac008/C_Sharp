using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Array    :  / array[i]  배열
///     List     :  /  list[i]   
///     
///     Indexer  : Class에 index사용 / this[DataType Variable]


namespace Book.Ch08
{

    class Ch08_4
    {
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
                SquareCalculator a = new SquareCalculator();
                Console.WriteLine(a[10]);                      
                Console.WriteLine(a[20]);
                Console.WriteLine(a[30]);
            }
        }


    }


    internal class p399
    {
    }
}
