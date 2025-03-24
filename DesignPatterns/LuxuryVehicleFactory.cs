using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class LuxuryVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateBike()
        {
            return new LuxuryBike();
        }

        public IVehicle CreateCar()
        {
            return new LuxuryCar();
        }
    }
}
