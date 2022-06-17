using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Array - array[i]
/// List - list[i]
/// indexer - dataType this[dataType variable]


/// indexer - class에 숫자 주입     /  dataType this[dataType variable]
/// 

namespace Book.Ch08
{

    class Ch08_4
    {
        class SquareCalculator
        {
            public int this[int i] { get { return i * i; } }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                SquareCalculator squar = new SquareCalculator();
                Console.WriteLine(squar[10]);                      ///[]에는 int자료형으로 넣는다.
                Console.WriteLine(squar[20]);
                Console.WriteLine(squar[30]);
            }
        }


    }


    internal class p399
    {
    }
}
