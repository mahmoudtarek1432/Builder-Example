using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsability_pattern.Structure
{
    internal abstract class Handler
    {
        public Handler successor;
        public void SetSuccessor(Handler Successor)
        {
            this.successor= Successor;
        }
        public abstract void handleRequest(int request);
    }
}
