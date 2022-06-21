using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Cable : ISocket
    {
        private Bulb bulb;               /// public Bulb bulb  :  ctrl. - 생성자 생성

        public Cable(Bulb bulb)          ///constructor
        { this.bulb = bulb; }

        public void SwitchOff()
        { bulb.LightOff(); }

        public void SwitchOn()
        { bulb.LightOn(); }
    }
}
