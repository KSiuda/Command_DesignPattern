using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandDesingPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            TVRemoteController pilot = new TVRemoteController();

            IElectronicDevice TV = pilot.GetDevice();

            PowerButton powBut = new PowerButton(TV);
            VolumeUpButton upBut = new VolumeUpButton(TV);
            VolumeDownButton downBut = new VolumeDownButton(TV);

            powBut.Execute();
            downBut.Execute();
            upBut.Execute();

            Console.ReadLine();


        }
    }

}