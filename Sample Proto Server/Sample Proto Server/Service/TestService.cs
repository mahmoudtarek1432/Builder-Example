using ProtobufWebsocket.Bidirectional_Helpers.Notification.Notification_Service;
using ProtobufWebsocket.Broadcast_Helper;
using Sample_Proto_Server.Endpoint.Test;
using Sample_Proto_Server.MockData;
using Sample_Proto_Server.Model;
using Sample_Proto_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProtobufWebsocket.EndpointApi.ProtoEndpointBase;

namespace Sample_Proto_Server.Service
{
    internal class TestService : ITestService
    {
        public readonly MockTest _test;
        private readonly INotificationService _notification;
        private readonly IBroadcastService _broadcast;

        public TestService(INotificationService notification, IBroadcastService broadcast)
        {
            _test = new MockTest();
            _test.seedTest();

            _notification = notification;
            _broadcast = broadcast;
        }

        public Test getTestById(string Id)
        {
            var test = _test.tests.Where(t => t.Id == Id).FirstOrDefault();
            return test;
        }


        public void SendBroadcast()
        {
            var req = new TestRequest { Id = "1" };
            _broadcast.EndpointBroadCast(req);
        }
    }
}
