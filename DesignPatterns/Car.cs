using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public bool HasGPS { get; set; }

        public override string ToString()
        {
            return $"Car with: Engine = {Engine}, Wheels = {Wheels}, GPS = {HasGPS}";
        }
    }
}
