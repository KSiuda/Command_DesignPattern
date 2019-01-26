using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPattern
{
    class TVRemoteController : IRemoteControlled
    {
     public IElectronicDevice GetDevice()
        {
            return new TV();
        }
    }
}
