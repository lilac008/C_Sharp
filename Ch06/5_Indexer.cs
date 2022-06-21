using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022 / 06 / 14
 * 이름 : 최희원
 * 내용 : Indexer (p398)
 *
 *
 *  Indexer : - object를 배열처럼 index를 사용해서 object의 데이터를 참조할 수 있게 해주는 속성
 *            - Indexer를 method로 대체 가능
 *  
 *  
 */


namespace Ch06
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        /// indexer
        public int this[int i]
        {
            get { return array[i]; }
            set
            {
                if (i < array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더 이상 데이터를 저장 할 수 없습니다.");
                }
            }
        }

        public int Length()
        {
            return array.Length;
        }
    }



    internal class _5_Indexer
    {
        static void Main1(string[] args)
        {
            MyList myList = new MyList();

            myList[0] = 100;               ///indexer 호출, 객체를 배열처럼, setter호출
            myList[1] = 101;
            myList[2] = 102;
            myList[3] = 103;               /// 100 / 101 / 102     <- 더 이상~ 출력

            for (int i = 0; i < myList.Length(); i++)
            {
                Console.WriteLine(myList[i]);               ///getter 호출 
            }



        }


    }
}
