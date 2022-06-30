using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final4
{
    internal class F4_01
    {
        class Box
        {
            private double width;
            private double height;
            private double depth;

            public Box(double width, double height, double depth)
            {
                this.width = width;
                this.height = height;
                this.depth = depth;
            }

            public double Volume() { return width * height * depth; }
        }

        static void Main1(string[] args)
        {
            Box b1 = new Box(10, 20, 30);
            Box b2 = new Box(3,6,9);

            Console.WriteLine("b1 부피 : "+b1.Volume());
            Console.WriteLine("b2 부피 : "+b2.Volume());
        }


    }
}
