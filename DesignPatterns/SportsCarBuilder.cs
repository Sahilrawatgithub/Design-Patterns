using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SportsCarBuilder:ICarBuilder
    {
        private Car car = new Car();

        public void SetEngine(string engineType)
        {
            car.Engine = engineType;
        }

        public void SetWheels(int number)
        {
            car.Wheels = number;
        }

        public void SetGPS(bool hasGPS)
        {
            car.HasGPS = hasGPS;
        }

        public Car GetResult()
        {
            return car;
        }
    }
}
