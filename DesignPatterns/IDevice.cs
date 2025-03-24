using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetVolume(int level);
    }
}
