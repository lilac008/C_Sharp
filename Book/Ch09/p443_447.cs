using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p443_447
    {
        static void Main1(string[] args)
        {

            /// StreamWriter w = new StreamWriter()   /// 우클릭 - 정의로이동 
            /// 상속관계 : MarshalByRefObject, IDisposable - abstract TextWriter - StringWriter - StreamWriter  (Abstract class는 instance를 만들 수 없다)

            /// Stream Writer Class로 파일에 문자열 쓰기
            using (StreamWriter w = new StreamWriter(@"c:\test\test.txt"))     ///using() : 예외 발생시 강제적으로 Dispose() 호출
            {
                w.WriteLine("안녕하세요");
                w.WriteLine("StreamWriter class를 사용");
                w.WriteLine("StreamWriter class로 파일에 문자열 쓰기");

                for (int i = 0; i < 10; i++)
                {
                    w.WriteLine("반복 - " + i);
                }
            }

            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));





            ///using()에서 StreamReader class instance 생성
            using (StreamReader r = new StreamReader(@"c:\test\test.txt"))
            {
                string s = r.ReadLine();
                Console.WriteLine(s);
            }
            Console.WriteLine();



            using (StreamReader r = new StreamReader(@"c:\test\test.txt"))
            {
                string s;
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();




        }
    }
}
