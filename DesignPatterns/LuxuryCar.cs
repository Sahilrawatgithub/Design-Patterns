using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class LuxuryCar : IVehicle
    {
        public string VehicleType()
        {
            return "This is a luxury vehicle";
        }

        public int Wheels()
        {
            return 4;
        }
    }
}
