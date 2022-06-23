using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  Class 기반의 OOP언어의 특징
///
///  Abstract 추상화 : 프로그램에 사용될 핵심적인 부분을 추출
///  캡슐화
///  상속
///  다형성



namespace Book.Ch05
{
    internal class p231_234
    {

        class Student                             /// Model Class : 인스턴스 변수만 가지고 있는 클래스
        {
            public string studentID;              /// 추상화 : 프로그램에 사용될 핵심적인 부분을 추출
            public string name;                   
            public int grade;
            public string major;
            public DateTime birthday;
        }




        static void Main1(string[] args)
        {
            ///List<className> variable = new List<className>();
            List<Student> li = new List<Student>();                   /// List Class
            li.Add(new Student() { name = "가", grade = 1 });
            li.Add(new Student() { name = "나", grade = 2 });
            li.Add(new Student() { name = "다", grade = 3 });
            li.Add(new Student() { name = "라", grade = 4 });
            li.Add(new Student() { name = "마", grade = 5 });
            li.Add(new Student() { name = "바", grade = 6 });

            foreach (var item in li)
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
