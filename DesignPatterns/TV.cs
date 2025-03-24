using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class TV : IDevice
    {
        public void SetVolume(int level)
        {
            Console.WriteLine($"Volume set to {level}");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is off");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is on");
        }
    }
}
