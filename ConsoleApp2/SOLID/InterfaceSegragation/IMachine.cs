using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    public interface IMachine
    {
        public void Print(Document document);
        public void Scann(Document document);
        public void Copy(Document document);   
    }
}
