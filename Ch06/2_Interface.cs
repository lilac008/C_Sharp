using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  
 * 날짜 : 2022/06/13
 * 이름 : 최희원
 * 내용 : Interface (p425 ch09)
 * 
 * 
 * Interface (객체와 객체 사이에서 상호작용) : - class간 공통의 통일된 표준 규격을 통해 class 구조를 설계
 *                                           - 다중 상속 구현
 *                                           - object간 결합도를 완화 (다형성)
 *                                           - abstract method만 포함하며, Interface로 구현된 object는 결합도가 낮아
 */

///    Parent    Parent2
///    ㅣ상속       ㅣ상속불가
///     child 
/// 
/// 
///     Parent   interface
///     ㅣ상속      ㅣ다중상속
///    child 
/// 


namespace Ch06
{
    internal class _2_Interface
    {
        static void Main1(string[] args)
        {
            /// interface로 공통 클래스 구조설계
            IRemoteControl lg = new LGRemoCon();
            IRemoteControl samsung = new SamsungRemoCon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundDown();
            samsung.PowerOff();

            /// interface를 활용한 다중 상속
            TV tv = new TV();                            ///다형성 적용x
            tv.PowerOn();
            tv.Booting();
            tv.Access();

            /// interface를 활용한 결합도 완화(다형성)    
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);           /// (bulb) 초기화

            socket.SwitchOn();
            socket.SwitchOff();


        }



    }
}
