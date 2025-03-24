using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Director
    {
        private ICarBuilder Builder;

        public Director(ICarBuilder builder)
        {
            Builder = builder;
        }

        public void ConstructSportsCar()
        {
            Builder.SetEngine("V8 Engine");
            Builder.SetWheels(4);
            Builder.SetGPS(true);
        }

        public Car GetCar()
        {
            return Builder.GetResult();
        }
    }
}
