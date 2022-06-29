using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     구조체 복사 - 참조 복사 / 값 복사

namespace Book.Ch08
{

    internal class p411
    {
        class PointClass                    ///class
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct                ///struct - class보다 안정적
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        static void Main1(string[] args)
        {
            ///class
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;                                      ///참조 복사

            pcB.x = 100;
            pcB.y = 200;

            Console.WriteLine("pointClassA: " + pcA.x + "," + pcA.y);   ///100,200 
            Console.WriteLine("pointClassB: " + pcB.x + "," + pcB.y);   ///100,200 
            Console.WriteLine();


            ///struct
            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;                                     ///값 복사

            psB.x = 100;
            psB.y = 200;

            Console.WriteLine("pointStructA: " + psA.x + "," + psA.y);  ///10,20
            Console.WriteLine("pointStructB: " + psB.x + "," + psB.y);  ///100,200
            Console.WriteLine();
        }
    }


    

}
