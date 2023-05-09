// See https://aka.ms/new-console-template for more information
using Chain_of_responsability_pattern.Structure;

Handler h1 = new ConcreteHandler1();
Handler h2 = new concreteHandler2();
Handler h3 = new concreteHandler3();
h1.SetSuccessor(h2);
h2.SetSuccessor(h3);

int[] requests = { 2, 3, 14, 22, 18, 3, 27, 20 };
foreach (int request in requests)
{
    h1.handleRequest(request);
}

Console.ReadKey();