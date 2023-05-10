// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtobufWebsocket.Services;
using Sample_Proto_Server.Service;

var host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddTransient<ITestService,TestService>();
    services.AddProtoWebsocketService(System.Reflection.Assembly.GetExecutingAssembly(), "ws://127.0.0.1/", "/test");
});

host.Build().Run();
