using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    abstract class Car                                    ///abstract class
    {
        /// Field
        protected string name;                            ///protected라야 참조 가능          
        protected string color;
        protected int speed;


        /// Constructor
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }


        /// Method
        public abstract void SpeedUp(int speed);          /// abstract method  -  p static v라고 하지 않는다. 클래스 정의할때 쓰임. / virtual?
        public abstract void SpeedDown(int speed);
        public virtual void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("차량속도 : " + speed);
        }




    }
}
