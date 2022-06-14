using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p235_237
    {

        class Student
        {
            public string name;      //instance 변수에 public을 적용하는 일은 거의 없다.
            public int grade;
        }

        static void Main1(string[] args)
        {

            List<Student> l1 = new List<Student>();
            l1.Add(new Student() { name = "가인성", grade = 1 });
            l1.Add(new Student() { name = "나하진", grade = 2 });
            l1.Add(new Student() { name = "다아린", grade = 3 });
            l1.Add(new Student() { name = "라명월", grade = 4 });
            l1.Add(new Student() { name = "마지연", grade = 1 });
            l1.Add(new Student() { name = "바연화", grade = 2 });


            // foreach - list 요소 제거
            /// foreach (var item in l1)
            /// {
            ///     if (item.grade > 1)
            ///     {
            ///         l1.Remove(item);
            ///     }
            /// }


            // for - list 요소 제거
            /// for (int f = 0; f < l1.Count; f++)
            /// {
            ///    if (l1[f].grade > 1)
            ///     {
            ///         l1.RemoveAt(f);
            ///     }
            /// }

            ///p236 참고해서 다시 정리할것



            //역 for - list 요소 제거
            for (int f1 = l1.Count - 1; f1 >= 0; f1--)
            {
                if (l1[f1].grade > 1)
                {
                    l1.RemoveAt(f1);
                }
            }

            foreach (var item in l1)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }











    }
}
