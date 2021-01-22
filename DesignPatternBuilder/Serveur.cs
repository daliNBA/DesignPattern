using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
   public class Serveur
    {
        private PizzaBuilder _pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }

        public void constructPizza()
        {
            _pizzaBuilder.CreateNewPizza();
            _pizzaBuilder.buildContenu();
            _pizzaBuilder.buildPate();
            _pizzaBuilder.buildSauce();
        }
    }
}
