using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///     날짜 : 2022/06/15
///     이름 : 최희원
///     내용 : Collection - Stack 
/// 
///
///     Collection : Data structure(데이터구조:data를 효율적으로 처리하기 위한 저장형태 및 방법)와 관련된 class 집합
///                 ArrayList, List, HashSet, HashTable, Dictionary
///  
///         Satack : data를 순서대로 쌓는 형태
///                  Last In First Out(후입선출 : 마지막에 입력된 데이터가 맨 위에 위치, 마지막 데이터를 제일 먼저 참조) 구조 
///



namespace Ch07
{
    internal class _1_Stack
    {
        static void Main1(string[] args)
        {
            Stack<int> a = new Stack<int>();

            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);
            a.Push(5);

            while (a.Count > 0)
            {
                Console.WriteLine(a.Pop());
            }


        }
    }
}
