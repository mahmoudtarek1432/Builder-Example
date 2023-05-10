using ProtobufWebsocket.Bidirectional_Helpers.Notification.Notification_Service;
using ProtobufWebsocket.EndpointApi;
using Sample_Proto_Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProtobufWebsocket.EndpointApi.ProtoEndpointBase;

namespace Sample_Proto_Server.Endpoint.Test
{
    internal class TestNotification : ProtoEndpointBase.Notification<TestResponse>
    {
        private INotificationService _notification;

        public TestNotification(INotificationService notification)
        {
            _notification = notification;
        }

        public async override Task<TestResponse> HandleAsync()
        {
            _notification.SendNotification<TestNotification>();
            return new TestResponse
            {
                Name = "NotificationTest",
                Version= 1,
                Comments = new[] {"Universal"}.ToList()
            };
        }
    }
}
