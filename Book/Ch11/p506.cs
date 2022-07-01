﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    deligate 활용
///    1)  Callback Method : 매개변수로 전달하는 method


namespace Book.Ch11
{
    internal class p506
    {
        class Student 
        {
            public string Name;
            public double Score;

            public Student(string name, double score)
            {
                this.Name = name;
                this.Score = score;
            }

            public override string ToString()
            {
                return this.Name + " : " + this.Score;
            }
        }

        class Students 
        {
            private List<Student> listofStudent = new List<Student>();               ///Private : 외부공개x

            public delegate void PrintPocess(Student list);

            public void Add(Student student) 
            {
                listofStudent.Add(student);
            }

            public void Print() 
            {
                Print( (student) => {Console.WriteLine(student);}  );
            }

            public void Print(PrintProcess process) 
            {
                foreach (var item in listOfStudent) { process(item); }
            }

        }

        static void Main1(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("윤인성", 4.2));
            students.Add(new Student("연하진", 4.4));

            students.Print();
            students.Print((student) => 
            {
                Console.WriteLine();
                Console.WriteLine("이름 : " + students.Name);
                Console.WriteLine("학점 : " + students.Score);
            });



        }




    }
}
