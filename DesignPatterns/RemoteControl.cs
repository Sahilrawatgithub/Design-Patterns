using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            Console.WriteLine("Toggling power");
            device.TurnOn();
        }

        public void VolumeUp()
        {
            Console.WriteLine("Increasing volume");
            device.SetVolume(10);
        }
    }
}
