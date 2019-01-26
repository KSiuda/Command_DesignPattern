using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPattern
{
    class VolumeDownButton : IControllable
    {
        private readonly IElectronicDevice _device;
        public VolumeDownButton(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeDown();
        }

       
    }
}
