using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Bike : IVehicle
    {
        public string vehicletype()
        {
            return "This is a bike";
        }

        public int wheels()
        {
            return 2;
        }
    }
}
