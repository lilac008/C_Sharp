using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    대리자 활용 : 1)  Callback Method


namespace Book.Ch11
{
    internal class p506
    {
        public delegate void CustomDelegate();

        public void Method(CustomDelegate customDelegate) 
        {
            CustomDelegate();
        }




    }
}
