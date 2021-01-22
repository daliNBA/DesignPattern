namespace DesignPatternBuilder
{
    public class PizzaMargueritte : PizzaBuilder
    {
        public override void buildPate()
        {
            pizza.setPate("moelleuse");
        }
        public override void buildSauce()
        {
            pizza.setSauce("douce");
        }
        public override void buildContenu()
        {
            pizza.setContenu("jambon+ananas");
        }

    }
}
