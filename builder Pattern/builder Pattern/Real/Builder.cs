using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Real
{
    abstract class VehicleBuilder
    {
        public Vehicle vehicle { get; set; }
        public abstract void BuildFrame();
        public abstract void BuildDoor();
        public abstract void BuildWheel();
        public abstract void buildEngine();
    }
}
