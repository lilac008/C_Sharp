using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///구조체 복사

namespace Book.Ch08
{

    class Ch08_12
    {
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        static void Main(string[] args)
        {
            //클래스
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;                                      ///참조복사

            pcB.x = 100;
            pcB.y = 200;

            Console.WriteLine("pointClassA: " + pcA.x + "," + pcA.y);
            Console.WriteLine("pointClassB: " + pcB.x + "," + pcB.y);
            Console.WriteLine();


            //구조체
            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;                                     ///값 복사

            psB.x = 100;
            psB.y = 200;

            Console.WriteLine("pointStructA: " + psA.x + "," + psA.y);
            Console.WriteLine("pointStructB: " + psB.x + "," + psB.y);
            Console.WriteLine();
        }
    }


    internal class p411
    {
    }
}
