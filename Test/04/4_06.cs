using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._04
{
    class MyIndexer<T>
    {
        private T[] arr = new T[10];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    internal class _4_06
    {
        static void Main1(string[] args)
        {
            /// MyIndexer m = new MyIndexer<string>();
            var m = new MyIndexer<string>();

            m[0] = "Hello, World!";
            m[1] = "Hello, Korea!";
            m[2] = "Hello, Busan!";
            m[3] = "Hello, C#!";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(m[i]);
            }
        }
    }
}
