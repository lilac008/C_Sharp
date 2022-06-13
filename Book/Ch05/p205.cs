using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{

    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;
    }

    public void SetInTime()
    { this.inTime = DateTime.Now; }

    public void SetOutTime()
    { this.outTime = DateTime.Now; }




    internal class p205
    {
        static void Main1(string[] args)
        {
            Car c1 = new Car();       //Car : 클래스, car : 인스턴스, new : 키워드, Car() : 생성자
            c1.SetInTime();
            c1.SetOutTime();
        }









    }
}
