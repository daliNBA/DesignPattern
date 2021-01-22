using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternFactory
{
    public class ComputerFactory
    {
       public static Computer GetComputer(string type, string ram, string cpu, string hdd)
        {
            if(type =="PC")
            {
                return new PC(ram, cpu, hdd);
            }
            if(type == "Tablette")
            {
                return new Tablette(ram, cpu, hdd);

            }
            return null;
        }
    }
}
