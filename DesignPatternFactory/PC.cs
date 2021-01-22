using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternFactory
{
    public class PC : Computer
    {
        private readonly string _CPU;
        private readonly string _HDD;
        private readonly string _Ram;
        public PC(string ram, string cpu, string hdd)
        {
            _CPU = cpu;
            _Ram = ram;
            _HDD = hdd;

        }
        public override string GetCPU()
        {
            return _CPU;
        }

        public override string GetHDD()
        {
            return _HDD;
        }

        public override string GetRam()
        {
            return _Ram;
        }
    }
}
