using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_Pattern.Structure
{
    internal class ConcreteBuilder2 : Builder
    {
        public Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product Result()
        {
            return _product;
        }
    }
}
