using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Exception Object :  1) FormatException
///                     2) IndexOutOfRangeException
///                     3) CustomException

namespace Book.Ch10
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)       /// base - 부모생성자 호출
        {
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {

            try
            {  throw new CustomException("사용자정의 예외");  }
            catch (CustomException e)
            {  Console.WriteLine(e.Message);  }



        }
    }


    internal class p482
    {
        
    }
}

