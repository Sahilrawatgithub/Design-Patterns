using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicle)
        {

            if (vehicle.Equals("bike", StringComparison.OrdinalIgnoreCase))
            {
                return new Bike();
            }
            else if (vehicle.Equals("car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else
            {
                return null;
            }
        }

    }
}
