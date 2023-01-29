using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    public interface IMultifunctional : IPrinter, IScanner
    {
        public void Copy(Document document);
    }
}
