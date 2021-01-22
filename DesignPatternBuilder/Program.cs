using System;

namespace DesignPatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Serveur serveur = new Serveur();
            PizzaBuilder pizzaMar = new PizzaMargueritte();
            PizzaBuilder pizzaThon = new PizzaThon();
            serveur.SetPizzaBuilder(pizzaMar);
            serveur.constructPizza();
            Pizza pizza = serveur.GetPizza();
            Console.WriteLine(pizza.toString());

            serveur.SetPizzaBuilder(pizzaThon);
            serveur.constructPizza();
            pizza = serveur.GetPizza();
            Console.WriteLine(pizza.toString());
        }
    }
}
