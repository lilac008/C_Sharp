using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Book.Ch06
{
    internal class p300
    {

        public int width { get; set; }             /// get, set 간단한 속성 생성법
        public int height { get; set; }



        public int MyProperty { get; set; }         /// ctrl space - prop - 탭 두번



        private int myVar;                         /// ctrl space - propfull - 탭 두번

        public int MyProperty1
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }
}
