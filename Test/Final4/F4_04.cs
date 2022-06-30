using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final4
{
    class Human 
    {
        private string name;                                ///호출불가
        private int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected void Hello()                              ///호출가능
        {
            Console.WriteLine("이름 : {0}", name);
            Console.WriteLine("나이 : {0}", age);
        }
    }

    class Student : Human 
    {
        private int studentID;

        public Student(string name, int age, int studentID) : base(name, age)
        {
            this.studentID = studentID;
        }

        protected void Hello()   //재귀메서드
        {
            //???????????
            Console.WriteLine("학번 : {0}\n", studentID);
        }
    }

    class Worker : Human 
    {
        private int workerID;

        public Worker(string name, int age, int workerID) : base(name, age)
        {
            this.workerID = workerID;
        }

        protected void Hello()  //재귀메서드
        {
            //???????????
            Console.WriteLine("사번 : {0}\n", workerID);
        }


    }

    internal class F4_04
    {
        static void Main(string[] args)
        {
            Student kim = new Student("김철수", 21, 20201234);
            Worker lee = new Worker("이철수", 35, 20211201);

            kim.Hello();
            lee.Hello();
           


        }



    }
}
