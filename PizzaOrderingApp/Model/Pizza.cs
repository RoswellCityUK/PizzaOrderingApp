namespace PizzaOrderingApp
{
    public class Pizza
    {
        public PizzaDough Dough { get; set; }
        public string Name { get; set; }
        public PizzaSauce Sauce { get; set; }
        public PizzaSize Size { get; set; }
        public List<PizzaTopping> Toppings { get; set; }
    }
}