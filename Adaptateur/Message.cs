using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptateur
{
    public class Message
    {
        private readonly string _alert;

        public Message(string alert)
        {
            _alert = alert;
        }

        public string Alerting()
        {
            return $"le message est {_alert}";
        }
    }
}
