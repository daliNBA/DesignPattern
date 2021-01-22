using System;
using TestAlgorithmique.Parse;

namespace TestAlgorithmique
{
    class Program
    {
        // Implémentation récursive de la fonction factorielle
        static long FactRect(long value)
        {
            if (value == 0) return 1;
            return value * FactRect(value - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Donner un nomber!");
            int number = Convert.ToInt32(Console.ReadLine());
            var Romain = new RomainTest(number);
            Romain.ParseToRomain();
            Romain.ParseToRomainTwo();
        }
    }
}
