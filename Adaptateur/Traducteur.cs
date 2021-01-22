using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptateur
{
    public class Traducteur : ITraducteur
    {
        private readonly Message _message;

        public Traducteur(Message message)
        {
            _message = message;
        }

        public string Traduit()
        {
            return $"{_message.Alerting()} in english is Hello!  ";
        }
    }
}
