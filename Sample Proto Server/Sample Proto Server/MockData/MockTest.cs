using Sample_Proto_Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Proto_Server.MockData
{
    internal class MockTest
    {
        public List<Test> tests = new List<Test>();

        public void seedTest()
        {
            tests.Add(new Test
            {
                Name = "test",
                Version = 1,
                Id = "1",
                Comments = new[]
                {
                    "first test comment",
                    "second test comment"
                }.ToList()

            });
            tests.Add(new Test
            {
                Name = "test 2",
                Version = 2,
                Id = "2",
                Comments = new[]
                {
                    "first test comment",
                    "second test comment"
                }.ToList()

            });
        }
    }
}
