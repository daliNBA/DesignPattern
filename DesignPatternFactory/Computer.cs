using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternFactory
{
    public abstract class Computer
    {
        public abstract string GetRam();
        public abstract string GetCPU();
        public abstract string GetHDD();

        public string toString()
        {
            return $"Ram = {GetRam()} CPU = {GetCPU()} and HDD = {GetHDD()}";
        }
    }
}
