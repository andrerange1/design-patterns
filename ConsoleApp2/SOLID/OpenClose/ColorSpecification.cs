using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OpenClose
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color Color;

        public ColorSpecification(Color color) 
        { 
            this.Color = color;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Color == Color;
        }
    }
}
