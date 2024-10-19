using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    internal interface IBuilder
    {
        void BuildRAM();
        void BuildROM();
        void BuildProcessor();
        Mobile GetInfo();
    }
}
