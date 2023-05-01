using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Real
{
    internal class Vehicle
    {
        public string VehicleType { get; set; }
        Dictionary<string,string> Parts = new Dictionary<string,string>();
        public Vehicle(string type)
        {
            VehicleType = type;
        }
        public string this[string key]
        {
            set { Parts[key] = value;}
            get { return Parts[key]; }
        }

        public void show()
        {
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            foreach(var part in Parts)
            {
                Console.WriteLine($"{part.Key}: {part.Value}");
            }
        }
    }
}
