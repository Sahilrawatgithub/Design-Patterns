using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class LuxuryBike : IVehicle
    {
        public string VehicleType()
        {
            return "This is a luxury bike";
        }

        public int Wheels()
        {
            return 2;
        }
    }
}
