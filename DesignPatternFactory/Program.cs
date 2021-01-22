using System;

namespace DesignPatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer com =  ComputerFactory.GetComputer("PC", "233", "Intel", "500");
            Console.WriteLine(com.toString());
        }
    }
}
