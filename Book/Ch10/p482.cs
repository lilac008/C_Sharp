using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch10
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {

            try
            {
                throw new CustomException("사용자 정의 예외");
            }
            catch (CustomException exception)
            {
                Console.WriteLine(exception.Message);
            }



        }
    }


    internal class p482
    {
        
    }
}

