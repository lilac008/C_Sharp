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
            public string name;               ///instance 변수는 private, public을 적용하는 일은 거의 없다.
            public int grade;
        }

        static void Main1(string[] args)
        {

            List<Student> li = new List<Student>();
            li.Add(new Student() { name = "가", grade = 1 });       ///index : 0
            li.Add(new Student() { name = "나", grade = 2 });       ///index : 1
            li.Add(new Student() { name = "다", grade = 3 });
            li.Add(new Student() { name = "라", grade = 4 });
            li.Add(new Student() { name = "마", grade = 1 });
            li.Add(new Student() { name = "바", grade = 2 });


            /// foreach - list 요소 제거 (오류 발생)
            ///foreach (var item in li)               
            ///{
            ///     if (item.grade > 1)  
            ///     {
            ///         li.Remove(item);
            ///     }
            ///}

            ///foreach (var item in li) 
            ///{
            ///    Console.WriteLine(item.name + ":" + item.grade );
            ///}


            /// for - list 요소 제거    (실행은 되지만 출력되지 않는다.) 이해불가 p236-237
            /// for (int f = 0; f < li.Count; f++)
            /// {
            ///    if (li[f].grade > 1)
            ///     {
            ///         li.RemoveAt(f);
            ///     }
            /// }


            ///  역 for - list 요소 제거
            for (int i = li.Count-1; i >= 0; i--)
            {
                if (li[i].grade > 1)
                {
                    li.RemoveAt(i);
                }
            }

            foreach (var item in li)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }











    }
}
