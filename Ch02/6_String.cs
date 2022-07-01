using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     날짜 : 2022/06/03
///     이름 : 최희원    
///     내용 : string,  (문자열 처리, 다른 데이터 유형으로 변환) (p112)
/// 
///
///      변수.Length
///      변수[index]
///      변수.IndexOf
///      변수.LastIndexOf
///      변수.Substring(index,length)   : 부분 문자열 출력
///      변수.Replace("변경전","변경후")
///    * 변수.ToString() ,  "" + 변수   : 기본형에서 문자열로
///    * 자료형.Parse(변수)             : 문자열에서 기본형으로
///     



namespace Ch02
{
    internal class _6_String
    {
        static void Main1(string[] args)
        {

            ///문자열 출력
            string greet = "Good Morning";
            Console.WriteLine("greeting : " + greet);
            Console.WriteLine();


            ///문자열 길이 - 변수.Length
            Console.WriteLine("greeting 길이 : " + greet.Length);
            Console.WriteLine();


            ///문자열 추출 - 변수[index]
            Console.WriteLine("greeting[0] : " + greet[0]);                 ///index(색인)은 항상 왼쪽부터 0,1,... 
            Console.WriteLine("greeting[3] : " + greet[3]);
            Console.WriteLine("greeting[5] : " + greet[5]);
            Console.WriteLine();


            ///문자열 검색 - 변수.IndexOf (앞에서부터 검색)
            Console.WriteLine("IndexOf 'G' : " + greet.IndexOf('G'));
            Console.WriteLine("IndexOf \"G\" : " + greet.IndexOf("G"));
            Console.WriteLine("IndexOf 'o' : " + greet.IndexOf('o')); 
            Console.WriteLine("IndexOf \"Mor\" : " + greet.IndexOf("Mor"));
            Console.WriteLine("IndexOf \"ing\" : " + greet.IndexOf("ing"));
            Console.WriteLine();


            ///문자열 검색 - 변수.LastIndexOf (뒤에서부터 검색)
            Console.WriteLine("LastIndexOf 'g' : " + greet.LastIndexOf('G'));
            Console.WriteLine("LastIndexOf 'o' : " + greet.LastIndexOf('o'));
            Console.WriteLine("LastIndexOf \"Mor\" : " + greet.LastIndexOf("Mor"));
            Console.WriteLine("LastIndexOf \"ing\" : " + greet.LastIndexOf("ing"));
            Console.WriteLine();


            ///문자열 부분출력 - 변수.Substring(index,length)
            Console.WriteLine("Substring(0,4) : {0}", greet.Substring(0, 4));             ///(0에서 4열)
            Console.WriteLine("Substring(5,7) : {0}", greet.Substring(5, 7));             ///(5에서 7열)
            Console.WriteLine("Substring(5) : {0}", greet.Substring(5));
            Console.WriteLine();


            ///문자열 교체 - 변수.Replace 
            string replaced = greet.Replace("Morning", "Afternoon");
            Console.WriteLine("replaced : " + replaced);
            Console.WriteLine();


            // 다른 데이터 유형으로 변환
            /// 기본형에서 문자열로 -  변수.ToString()    /   "" + 변수
            int a1 = 1;
            double a2 = 2.12;
            bool a3 = true;

            string str1 = a1.ToString();                            /// (string) 으로 변환 불가. 
            string str2 = a2.ToString();
            string str3 = "" + a3;

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine();


            /// 문자열에서 기본형으로 -  자료형.Parse(변수)         
            string b1 = "3";
            string b2 = "3.14";                                   
            string b3 = "false";

            int    c1  =  int.Parse(b1);
            double c2  =  double.Parse(b2);
            bool   c3  =  bool.Parse(b3);

            Console.WriteLine($" r1 : {c1} ");
            Console.WriteLine($" r2 : {c2} ");
            Console.WriteLine($" r3 : {c3} ");
            Console.WriteLine();






        }

       
    }
}
