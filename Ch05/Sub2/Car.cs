using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ch05.Sub2
{
    internal class Car
    {
        private string name;                 /// Field     (블록지정 - 빠른 리팩터링 - 캡슐화)
        private string color;
        private int speed;


        public string Name { get { return name; } set { name = value; } }    /// Getter, Setter --> C#에서는 프로퍼티,     N,C 대문자
        public string Color { get { return color; } set { color = value; } }
        public int Speed
        {
            get
            { return speed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                { speed = value; }
            }
        }

        
        public Car(string name, string color, int speed)      ///Constructor
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        ~Car()                                             /// Destrructor
        {
            Console.WriteLine("{0} Car 소멸자 실행...", name);
        }



        public void SpeedUp(int speed)                        /// method,        p static v라고 하지 않는다. 클래스 정의할때 쓰임.
        {
            this.speed += speed;
        }

        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("차량속도 : " + speed);
        }

    }
}
