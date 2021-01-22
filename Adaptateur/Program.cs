using System;

namespace Adaptateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("Bonjour!");
            ITraducteur traducteur = new Traducteur(message);
            Console.WriteLine(traducteur.Traduit());
        }
    }
}
