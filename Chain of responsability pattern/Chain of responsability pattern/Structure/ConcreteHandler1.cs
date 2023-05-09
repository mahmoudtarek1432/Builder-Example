using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsability_pattern.Structure
{
    internal class ConcreteHandler1 : Handler
    {
        public override void handleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}",this.GetType().Name,request);
            }
            else if( successor != null)
            {
                successor.handleRequest(request);
            }
        }
    }

    internal class concreteHandler3 : Handler
    {
        public override void handleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.handleRequest(request);
            }
        }
    }

    internal class concreteHandler2 : Handler
    {
        public override void handleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.handleRequest(request);
            }
        }
    }
}
