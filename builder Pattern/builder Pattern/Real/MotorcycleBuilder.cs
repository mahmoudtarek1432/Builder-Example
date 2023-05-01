using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Real
{
    internal class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildDoor()
        {
            vehicle["Door"] = "0";
        }

        public override void buildEngine()
        {
            vehicle["Engine"] = "150cc";
        }

        public override void BuildFrame()
        {
            vehicle["Frame"] = "Motorcycle Frame";
        }

        public override void BuildWheel()
        {
            vehicle["Wheels"] = "2";
        }
    }
}
