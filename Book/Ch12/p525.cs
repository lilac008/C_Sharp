using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch12
{
    internal class p525
    {
        static void Main1(string[] args)
        {

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            foreach (var item in input)
            {
                if (item % 2 == 0) { output.Add(item); }
            }
            //return output;



            ///
            //List<int> input2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //return from item in input2
            //       where item % 2 == 0
            //       select item;

            //var output = from item in input
            //             where item % 2 == 0
            //            orderby item
            //             select item;







        }


    }
}
