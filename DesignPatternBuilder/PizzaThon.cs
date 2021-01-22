using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class PizzaThon : PizzaBuilder
    {
        public override void buildPate()
        {
            pizza.setPate("cuite");
        }
        public override void buildSauce()
        {
            pizza.setSauce("huile d'olive");
        }
        public override void buildContenu()
        {
            pizza.setContenu("saumon+mozzarella");
        }

    }
}
