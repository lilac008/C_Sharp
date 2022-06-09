using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p100_103
    {   /////var n = 100;    인스턴스 변수 (var keyword 사용 불가) p101
        static void Main1(string[] args)
        {

            //Var - 자동으로 변수 지정 (변수 n에 커서두기)
            var n = 100;


            // 오류 p100
            // var n1 = 100;
            // n1 = "변경";


            //지역변수 (svm내에서 var keyword 사용 가능) p101


            //var - 키워드의 선언과 초기화 동시 수행
            var n2 = 20;


            //var - 다양한 자료형 선언 (* 겹칠경우 L, F로 구분해야 한다.)
            var v1 = 100L;
            var v2 = 100.0F;
            var v3 = 100.0;









        }
    }
}
