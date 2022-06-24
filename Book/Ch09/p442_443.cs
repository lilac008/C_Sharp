using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p442_443
    {
        static void Main1(string[] args)
        {

            /// 파일에 문자열 쓰기  (C:에 test 폴더가 있어야 함)          
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 쓴다");  /// escape 문자 : \\ 
                                                                            /// @ : 문자열 앞에 붙여 문자열을 생성하게 한다. 단, escape문자는 사용할 수 없다. 

            /// 파일을 읽기
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
            Console.WriteLine();



        }
    }
}
