using pizzaportal.Models;
namespace pizzaportal
{
    public class pizzadetails
    {
        public List<Pizza> pizza = new List<Pizza>();
        public void add()
        {

            Pizza p = new Pizza();
            p.PizzaId = 1;
            p.PizzaName = "Cheese Pizza";
            p.Price = 150;
            pizza.Add(p);

            Pizza p1 = new Pizza();
            p1.PizzaId = 2;
            p1.PizzaName = "Pan Pizza";
            p1.Price = 100;
            pizza.Add(p1);

            Pizza p2 = new Pizza();
            p2.PizzaId = 3;
            p2.PizzaName = "Chicken Pizza";
            p2.Price = 300;
            pizza.Add(p2);

            Pizza p3 = new Pizza();
            p3.PizzaId = 4;
            p3.PizzaName = "Mushroom Pizza";
            p3.Price = 200;
            pizza.Add(p3);

        }
    }
}
