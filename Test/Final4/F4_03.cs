using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final4
{
    class Adder 
    {
        public int x;

        public Adder(int x)
        {
            this.x = x;
        }

        public void Add(int x)
        {
            this.x = x+50;
        }

        public void Add(int[] arr)
        {
            arr[0]++;
        }

        public void Add(Adder a1) 
        {
            a1.x = a1.x + 40;
        }

        public ????? Add(Adder a2, int value)
        {
            return new Adder(value);
        }

    }


    internal class F4_03
    {
        static void Main(string[] args)
        {
            int[] arr = { 10,20,30 };

            Adder c1 = new Adder(100);

            c1.Add(100);
            Console.WriteLine("1) " + c1.x);

            c1.Add(c1);
            Console.WriteLine("2) " + c1.x);

            c1.Add(arr);
            Console.WriteLine("3) " + arr[0]);

            c1 = c1.Add(c1, 1);
            Console.WriteLine("4) " + c1.x);


        }
    }
}
