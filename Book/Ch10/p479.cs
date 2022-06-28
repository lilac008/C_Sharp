using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     예외 강제 발생 : 
///   
/// try {  throw new Exception();  }
/// catch(Exception e) { }
/// 

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
                Console.WriteLine("::예외 발생::"); 
            }








        }






    }
}
