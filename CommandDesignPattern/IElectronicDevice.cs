using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPattern
{
    interface IElectronicDevice
    {
        bool PoweredOn { get; set; }
        void PowerOnOff();
        void VolumeUP();
        void VolumeDown();
    
    }
}
