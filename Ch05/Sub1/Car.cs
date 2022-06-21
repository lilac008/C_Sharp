using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 메모리 구조
 * 
 *    Heap (위치 랜덤, 16byte) 
 *    ex) car(name, color, speed) / account(bank, accountID, name, bank)
 * 
 *    Stack (위치 차곡차곡, 4byte) 
 *    ex) sonata, bmw. kb, nh 
 * 
 */



namespace Ch05.Sub1
{
    internal class Car
    {
        /// Field
        public string name;
        public string color;
        public int speed;


        /// Method
        public void SpeedUp(int speed)                /// static 하지 않는다. 클래스 정의할때 쓰임.
        { this.speed += speed; }

        public void SpeedDown(int speed)
        { this.speed -= speed; }

        public void Show()
        {
            Console.WriteLine("============");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("차량속도 : " + speed);
        }



    }
}
