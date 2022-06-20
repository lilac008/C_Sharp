using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// throw new Exception(); - 강제로 예외 발생시키기

namespace Book.Ch10
{
    internal class p479
    {
        static void Main1(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("예외가 발생했습니다.");
            }

        }






    }
}
