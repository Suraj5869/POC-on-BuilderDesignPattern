using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    internal class MobileDirector
    {
        public MobileDirector(IBuilder builder)
        {
            builder.BuildROM();
            builder.BuildRAM();
            builder.BuildProcessor();
        }
    }
}
