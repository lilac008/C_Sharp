using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Book.Ch10
{
    internal class p474
    {
        static void Main1(string[] args)
        {

            /// Exception -  Object에서 정보 추출
            Console.Write("입력 : ");
            string a3 = Console.ReadLine();

            try
            {
                int b3 = int.Parse(a3);
                Console.WriteLine("입력 숫자 : " + b3);
            }
            catch (Exception e3)
            {
                Console.WriteLine("예외 발생");
                Console.WriteLine(e3.GetType());             ///e3. - e3 클래스의 인스턴스. 
                Console.WriteLine(e3.Message);
                Console.WriteLine(e3.StackTrace);
                return;                                      ///return - 종료 키워드
            }
        }






    }
}
