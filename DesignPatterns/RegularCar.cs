using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class RegularCar : IVehicle
    {
        public string VehicleType()
        {
            return "This is a regular car";
        }

        public int Wheels()
        {
            return 4;
        }
    }
}
