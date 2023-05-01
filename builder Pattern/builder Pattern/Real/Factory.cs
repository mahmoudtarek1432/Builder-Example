using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Real
{
    internal class Factory
    {
       public void Construct(VehicleBuilder builder)
        {
            builder.BuildWheel();
            builder.buildEngine();
            builder.BuildDoor();
            builder.BuildFrame();
        }
    }
}
