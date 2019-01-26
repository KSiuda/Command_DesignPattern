using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesingPattern
{
    class TV : IElectronicDevice
    {
        public TV(bool power = false, int volume = 25)
        {
            PoweredOn = power;
            Volume = volume;
        }

        public bool PoweredOn { get; set ; }
        public int Volume { get; set; }

        public void PowerOnOff()
        {
            if (PoweredOn)
            {
                PoweredOn = false; Console.WriteLine("PoweredOff");
            }

            else
            {
                PoweredOn = true; Console.WriteLine("PoweredON");
            }
                
        }


        public void VolumeDown()
        {
            Volume -= 1;
            Console.WriteLine($"Volume is {Volume}");
        }

        public void VolumeUP()
        {
            Volume += 1;
            Console.WriteLine($"Volume is {Volume}");
        }
    }
}
