using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    internal class AppleBuilder : IBuilder
    {
        Mobile mobile = new Mobile();
        public void BuildProcessor()
        {
            mobile.SetPROCESSOR("Build Apple Processor");
        }

        public void BuildRAM()
        {
            mobile.SetRAM("8GB");
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
