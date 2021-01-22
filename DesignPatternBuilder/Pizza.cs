using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Pizza
    {
        private string _sauce;
        private string _pate;
        private string _contenu;

        public void setPate(string pate)
        {
            _pate = pate;
        }
        public void setSauce(string sauce)
        {
            _sauce = sauce;
        }
        public void setContenu(string contenu)
        {
            _contenu = contenu;
        }

        public string toString()
        {
            return $"la sauce est {_sauce} et {_contenu}  {_pate}";
        }
    }
}
