using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Array    :  / array[i]  배열
///     List     :  /  list[i]   
///     
///     Indexer  : Class에 index사용 / this[DataType Variable]


namespace Book.Ch08
{

    class Ch08_3
    {
        public int this[int i]                             /// this[int i]로 선언
        {

            //Products a = new Product();
            //a[i] 할때 호출                                        /// p[i]의 자료형도 int                  
            get { return i; }
            //a[i] = 10할때 호출
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }



    internal class p398
    {
    }
}
