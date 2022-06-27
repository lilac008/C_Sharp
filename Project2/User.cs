using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class User
    {
        private string uid;                      /// field
        private string name;
        private string hp;
        private int age;


        public string Uid  { get => uid;  set => uid = value;  }   /// field 캡슐화 - 속성 사용 (get, set)
        public string Name { get => name; set => name = value; }
        public string Hp   { get => hp;   set => hp = value;   }
        public int Age     { get => age;  set => age = value;  }

    }
}
