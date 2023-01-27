using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OpenClose
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size Size;

        public SizeSpecification(Size size) 
        {
            this.Size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == Size;
        }
    }
}
