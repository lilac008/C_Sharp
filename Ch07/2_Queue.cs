using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * 날짜 : 2022 / 06 / 15
 * 이름 : 최희원
 * 내용 : Collection - Queue  ()
 * 
 * 
 *  Queue
 *    First in First Out(선입선출) 구조 : 순서대로 입력된 데이터를 차례대로
 * 
 * 
 */



namespace Ch07
{
    internal class _2_Queue
    {
        static void Main1(string[] args)
        {

            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("1");
            q1.Enqueue("2");
            q1.Enqueue("3");
            q1.Enqueue("4");
            q1.Enqueue("5");

            while (q1.Count > 0)
            {
                Console.WriteLine(q1.Dequeue());
            }







        }
    }
}
