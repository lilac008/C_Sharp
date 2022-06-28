using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Exception Object :  1) FormatException
///                     2) IndexOutOfRangeException
///                     3) CustomException

/// try {}
/// catch (FormatException e) {}  
/// catch (IndexOutOfRangeException e) {}  


namespace Book.Ch10
{
    internal class p477
    {
        static void Main1(string[] args)
        {

            /// 배열 범위를 벗어난 예외 발생
            Console.Write("입력 : ");
            string a = Console.ReadLine();
            int[] arr = { 1, 2, 3, 4 };

            int i = int.Parse(a);

            Console.WriteLine();
            Console.WriteLine("입력 숫자 : " + i);
            Console.WriteLine("배열 요소 : " + arr[i]);
            Console.WriteLine();


            /// try, catch, catch 
            Console.Write("입력 : ");
            try
            {
                string a1 = Console.ReadLine();
                int[] arr1 = { 1, 2, 3, 4 };

                int i1 = int.Parse(a1);

                Console.WriteLine();
                Console.WriteLine("입력 숫자 : " + i1);
                Console.WriteLine("배열 요소 : " + arr1[i1]);
                Console.WriteLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException 발생");                         ///ㅇㅂㅇ 입력시
                Console.WriteLine(e.GetType() + "이 발생하였습니다.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException 발생");                ///52273 입력시
                Console.WriteLine(e.GetType() + "이 발생하였습니다.");
            }


           /// 주의 : 
           /// catch(var exception) {}   - catch구문에는 var 입력 X
           


        }








    }
}
