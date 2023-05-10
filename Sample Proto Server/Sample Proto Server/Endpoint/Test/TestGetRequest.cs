using ProtobufWebsocket.EndpointApi;
using Sample_Proto_Server.DTO;
using Sample_Proto_Server.Models;
using Sample_Proto_Server.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.Endpoint.Test
{
    internal class TestGetRequest : ProtoEndpointBase.Request<TestRequest>.WithResponse<TestResponse>
    {
        private ITestService _testService;

        public TestGetRequest(ITestService testservice)
        {
            _testService = testservice;
        }

        public override async Task<TestResponse> HandleAsync(TestRequest Request)
        {
            var test = _testService.getTestById(Request.Id);
            var response = new TestResponse
            {
                Comments = test.Comments,
                Name = test.Name,
                Version = test.Version,
            };

            

            return response;
        }
    }
}
