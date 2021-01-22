using System;

namespace Facade
{
    //La Façade est un patron de conception structurel qui 
    //fournit une interface simplifiée (mais limitée)
    //à un système complexe de classes, 
    // bibliothèques ou frameworks.
    class Program
    {
        static void Main(string[] args)
        {
            var sys1 = new SubSystem1();
            var sys2 = new SubSystem2();
            var facade = new Facade(sys1, sys2);
            Client.ClientCode(facade);
        }
    }
}
