using Sample_Proto_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.Service
{
    internal interface ITestService
    {
        public Test getTestById(string Id);
    }
}
