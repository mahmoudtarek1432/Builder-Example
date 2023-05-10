using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.Model
{
    internal class Test
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public int Version { get; set; }

        public List<string> Comments { get; set; }
    }
}
