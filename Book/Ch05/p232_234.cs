using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p232_234
    {

        class Student                                                // Model Class
        {
            public string name;
            public int grade;
        }

        static void Main1(string[] args)
        {

            List<Student> l1 = new List<Student>();                  // List Class
            l1.Add(new Student() { name = "가인성", grade = 1 });
            l1.Add(new Student() { name = "나하진", grade = 2 });
            l1.Add(new Student() { name = "다아린", grade = 3 });
            l1.Add(new Student() { name = "라명월", grade = 4 });
            l1.Add(new Student() { name = "마지연", grade = 1 });
            l1.Add(new Student() { name = "바연화", grade = 2 });

            foreach (var item in l1)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }


            // List, Model Class 동시 초기화 (p234 미완성 구조라서 막음)
            ///
            ///List<Student> l1 = new List<Student>();
            ///{
            ///    new Student() { name = "윤인성", grade = 1 },
            ///    new Student() { name = "연하진", grade = 2 },
            ///    new Student() { name = "윤아린", grade = 3 },
            ///    new Student() { name = "윤명월", grade = 4 },
            ///    new Student() { name = "구지연", grade = 1 },
            ///    new Student() { name = "김연화", grade = 2 }
            ///
            ///};
        }







    }
}
