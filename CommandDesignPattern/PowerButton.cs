using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPattern
{
    class PowerButton : IControllable
    {
        private readonly IElectronicDevice _device;
        public PowerButton(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.PowerOnOff();
        }

    }
}
