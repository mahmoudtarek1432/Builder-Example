using ProtobufWebsocket.Attributes;
using ProtobufWebsocket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.Models
{
    [EndpointRequest]
    internal class TestRequest : IRequest
    {
        public string Id { get; set; }
    }
}
