using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Car : IVehicle
    {
        public string vehicletype()
        {
            return "This is a car";
        }

        public int wheels()
        {
            return 4;
        }
    }
}
