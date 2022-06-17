using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    class Ch06_10
    {
        class Test
        {
            public void TestMethod()
            {
                //Program.Main(new string[] { "" });         ///inner class의 method에서 private method 접근 
            }
        }

        public void TestMethod()
        {
            //Program.Main(new string[] { "" });            ///자기 class가 가진 method에서 private method 접근
        }

        class Program
        {
            static void Main1(string[] args)
            {

            }
        }
    }


    internal class p281
    {
    }
}
