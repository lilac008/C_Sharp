using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Exception Object (예외 객체) : Exception class의 instance

/// try {}
/// catch (Exception e)      -   e가 Exception Object
/// {
///     e.GetType()
///     e.InnerException
///     e.Message
///     e.StackTrace
///     e.Source
///     e.ToString()
/// }  


namespace Book.Ch10
{
    internal class p474
    {
        static void Main1(string[] args)
        {

            

            /// Exception Object에서 정보 추출

            Console.Write("입력 : ");
            string a = Console.ReadLine();

            try
            {
                int b = int.Parse(a);
                Console.WriteLine("입력 숫자 : " + b);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(e.GetType());             
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return;                                      
            }
        }






    }
}
