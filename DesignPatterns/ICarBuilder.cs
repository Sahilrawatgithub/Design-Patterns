using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface ICarBuilder
    {
        void SetEngine(string engineType);
        void SetWheels(int number);
        void SetGPS(bool hasGPS);
        Car GetResult();
    }
}
