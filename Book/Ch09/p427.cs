using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{

    internal class p427
    {

        class Product : IComparable               ///1. IComparable 블록지정, 2-1 Ctrl. - 인터페이스구현 or 2-2 우클릭 - 빠른작업 리팩터링 - 인터페이스구현
        {
            public string Name { get; set; }     
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
                        
            public int CompareTo(object obj)                            ///IComparable 블록지정 : 인터페이스 구현
            {
                return this.Price.CompareTo((obj as Product).Price);    ///CompareTo() method
            }



        }












    }
}
