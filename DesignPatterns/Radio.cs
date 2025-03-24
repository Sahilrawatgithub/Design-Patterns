using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Radio : IDevice
    {
        public void SetVolume(int level)
        {
            Console.WriteLine($"Volume set to {level}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio is off");
        }

        public void TurnOn()
        {

            Console.WriteLine("Radio is on");
        }
    }
}
