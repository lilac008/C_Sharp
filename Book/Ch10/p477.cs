using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch10
{
    internal class p477
    {
        static void Main1(string[] args)
        {

            /// Exception Situaltion
            Console.Write("입력 : ");
            string i = Console.ReadLine();
            int[] arr = { 1, 2, 3, 4 };

            int index = int.Parse(i);

            Console.WriteLine();
            Console.WriteLine("입력 숫자 : " + index);
            Console.WriteLine("배열 요소 : " + arr[index]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            /// try {}
            /// catch(예외1) {} 
            /// catch(예외2) {}
            ///
            Console.Write("입력 : ");

            try
            {
                string i1 = Console.ReadLine();
                int[] arr1 = { 1, 2, 3, 4 };

                int index1 = int.Parse(i1);

                Console.WriteLine();
                Console.WriteLine("입력 숫자 : " + index1);
                Console.WriteLine("배열 요소 : " + arr1[index1]);
                Console.WriteLine();
                Console.WriteLine();
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


            /// 오류 조심
            /// try {}
            /// catch(var exception) {}   - var 키워드 입력시 오류 발생


        }








    }
}
