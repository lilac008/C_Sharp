using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        
        protected string name;                          /// Field,   1) 식클래스에서 참조할 수 있게 private에서 protected로 수정
        protected string color;                         ///          2) 블록지정 - 빠른 리팩터링 - 캡슐화
        protected int speed;

        public Car(string name, string color, int speed)  /// Constructor : 캡슐화된 속성을 초기화 하기 위한 Method.
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        public void SpeedUp(int speed)                  /// method,  p static v라고 하지 않는다. 클래스 정의할때 쓰임. 
        {
            this.speed += speed;                        /// speed 두개가 지정하는 것이 다르니 조심
        }

        public void SpeedDown(int speed) 
        {
            this.speed -= speed;                        /// speed 두개가 지정하는 것이 다르니 조심
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
