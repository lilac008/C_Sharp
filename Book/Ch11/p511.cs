using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class p511
    {
        static void Main1(string[] args)
        {
            ///1 Thread 생성 (Thread Class를 사용)
            Thread threadA = new Thread(TestMethod);                    ///생성자 매개변수 - methd명
            Thread threadB = new Thread(delegate () { });               ///생성자 매개변수 - 무명delegate
            Thread threadC = new Thread(() => { });                     ///생성자 매개변수 - Lamda



            ///2 Thread 실행
            Thread threadAA = new Thread(() => { for (int i = 0; i < 1000; i++) { Console.Write("A"); }    });
            Thread threadBB = new Thread(() => { for (int i = 0; i < 1000; i++) { Console.Write("B"); }    });
            Thread threadCC = new Thread(() => { for (int i = 0; i < 1000; i++) { Console.Write("C"); }    });
                
            threadAA.Start();
            threadBB.Start();
            threadCC.Start();




        }
        ///1-1
        public static void TestMethod() { }
    }
}
