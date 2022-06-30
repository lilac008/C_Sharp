using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  날짜 : 2022/06/20 
///  이름 : 최희원
///  내용 : File Input / Output (파일입출력) (p479)
///   
/// 
///   File Input / Output  :  file은 HDD(Hard Disk Drive)에 저장되는 데이터 묶음.
///                           프로그램은 데이터 처리와 더불어 처리 결과를 저장하기 위해 파일 입출력을 수행.
///   


namespace Ch08
{
    internal class _3_File_IO
    {
        static void Main1(string[] args)
        {


            /// File Read (입력)

            string path1 = "C:\\Users\\1302\\Desktop\\Sample1.txt";


            FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);            ///stream 생성
            StreamReader sr = new StreamReader(fs);                                           /// txt 파일 전용, 보조 stream 연결


            string line;                                                                      /// read the file
            while ((line = sr.ReadLine()) != null)
            { Console.WriteLine(line); }

            sr.Close();                                                                       /// close the file
            fs.Close();
            Console.WriteLine();




            /// File Write (출력)

            string path2 = "C:\\Users\\1302\\Desktop\\Sample2.txt";

            FileStream fs2 = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);       ///stream 생성
            StreamWriter sw = new StreamWriter(fs2);

            sw.WriteLine("Welcome World!");                                                        /// write the file
            sw.WriteLine("Welcome Korea!");
            sw.WriteLine("Welcome Busan!");

            sw.Close();                                                                            /// close the file
            fs2.Close();
            Console.WriteLine();

        }


    }
}
