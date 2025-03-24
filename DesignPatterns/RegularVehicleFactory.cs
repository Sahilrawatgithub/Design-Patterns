using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class RegularVehicleFactory:IVehicleFactory
    {
        public IVehicle CreateBike()
        {
            return new RegularBike();
        }

        public IVehicle CreateCar()
        {
            return new RegularCar();
        }
    }
}
