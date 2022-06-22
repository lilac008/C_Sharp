using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tem3
{
    internal class Member  ///DataGridView
    {

        private string uid;
        private string name;
        private string hp;
        private int age;

        public Member(string uid, string name, string hp, int age)  ///constructor
        {
            this.Uid = uid;
            this.Name = name;
            this.Hp = hp;
            this.Age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age { get => age; set => age = value; }

        ///public string Uid  { get => uid; set => uid = value; }   /// 빠른작업 리팩터링 - 캡슐화(속성을 사용함)
        ///public string Name { get => name; set => name = value; }
        ///public string Hp   { get => hp; set => hp = value; }
        ///public int Age     { get => age; set => age = value; }

        ///public string Uid  { get => uid; set => uid = value; }   /// 빠른작업 리팩터링 - 캡슐화(여전히 필드를 사용함)
        ///public string Name { get => name; set => name = value; }
        ///public string Hp   { get => hp; set => hp = value; }
        ///public int Age     { get => age; set => age = value; }




    }
}
