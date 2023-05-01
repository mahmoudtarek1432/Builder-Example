using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Real
{
    internal class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }
        public override void BuildDoor()
        {
            vehicle["Door"] = "4";
        }

        public override void buildEngine()
        {
            vehicle["Engine"] = "1500cc";
        }

        public override void BuildFrame()
        {
            vehicle["Frame"] = "Car Frame";
        }

        public override void BuildWheel()
        {
            vehicle["Wheels"] = "4";
        }
    }
}
