using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    internal class Mobile
    {
        string _RAM;
        string _ROM;
        string _PROCESSOR;

        public void SetRAM(string ram)
        {
            _RAM = ram;
        }

        public void SetROM(string rom) 
        {
            _ROM = rom;
        }

        public void SetPROCESSOR(string processor)
        {
            _PROCESSOR = processor;
        }

        public string DisplayInfo()
        {
            return $"Mobile Configuration:\n" +
                $"RAM : {_RAM}\n" +
                $"ROM : {_ROM}\n" +
                $"Processor : {_PROCESSOR}\n";
        }
    }
}
