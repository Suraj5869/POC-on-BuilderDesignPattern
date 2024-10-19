using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    internal class NokiaBuilder : IBuilder
    {
        Mobile mobile = new Mobile();
        public void BuildProcessor()
        {
            mobile.SetPROCESSOR("Build Nokia processor");
        }

        public void BuildRAM()
        {
            mobile.SetRAM("4GB");
        }

        public void BuildROM()
        {
            mobile.SetROM("64GB");
        }

        public Mobile GetInfo()
        {
            return mobile;
        }
    }
}
