using ProtobufWebsocket.Attributes;
using ProtobufWebsocket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.DTO
{
    [EndpointResponse]
    internal class TestResponse : IResponse
    {
        public string Name { get; set; }

        public int Version { get; set; }

        public List<string> Comments { get; set; }
    }
}
