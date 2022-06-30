using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///    대리자 활용 : 1)  Callback Method : 매개변수로 전달하는 method


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
                
            }

        }





    }
}
