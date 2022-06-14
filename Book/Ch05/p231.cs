using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///  Class 기반의 OOP언어의 특징
///
///  추상화 : 프로그램에 사용될 핵심적인 부분을 추출하는 것
///  캡슐화
///  상속
///  다형성




namespace Book.Ch05
{
    internal class p231
    {
        class Student  // Model Class(모델 클래스) : 인스턴스 변수만 가지고 있는 클래스
        {

            // 추상화 : 프로그램에 사용될 핵심적인 부분을 추출하는 것

            public string studentID;
            public string name;
            public int grade;
            public string major;
            public DateTime birthday;

        }







    }
}
