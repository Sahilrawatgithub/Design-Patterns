using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class RegularBike:IVehicle
    {
        public string VehicleType()
        {
            return "This is a regular bike.";
        }

        public int Wheels()
        {
            return 2;
        }
    }
}
