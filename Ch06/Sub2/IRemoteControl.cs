using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///interface 로 만들어졌음을 알리기 위해 제목 앞에 I를 붙인다.



namespace Ch06.Sub2
{
    internal class IRemoteControl
    {
        /// interface는 abstract method만 갖는다.
        public abstract void PowerOn();
        public abstract void PowerOff();

        public void ChUp();   /// abstract 생략
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
