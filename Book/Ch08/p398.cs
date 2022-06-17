using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///     Array    :  array[i]
///     List     :  list[i]
///     indexer  :  dataType this[dataType i]


/// indexer - class에 사용     /  dataType this[dataType variable]
/// 




namespace Book.Ch08
{

    class Ch08_3
    {
        public int this[int i]                             /// this[int i] : indexer 선언, int 형으로
        {

            ///Products p = new Product();
            ///p[i]                                         /// p[i]의 자료형도 int                  
            get { return i; }
            ///p[i] = 10할때 호출
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }



    internal class p398
    {
    }
}
