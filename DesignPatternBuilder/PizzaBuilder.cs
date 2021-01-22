namespace DesignPatternBuilder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public Pizza GetPizza()
        {
            return pizza;
        }
        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void buildPate();
        public abstract void buildSauce();
        public abstract void buildContenu();
    }
}
