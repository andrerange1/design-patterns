﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
