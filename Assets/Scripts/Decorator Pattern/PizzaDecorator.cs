using System.Collections.Generic;

namespace GamePatterns
{
    /// <summary>
    /// This class will serve as the base decorator class
    /// </summary>
    public class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        //Constructor which feeds the pizza in
        public PizzaDecorator(IPizza _pizza)
        {
            pizza = _pizza;
        }

        public virtual List<string> GetIngredients()
        {
            return pizza.GetIngredients();
        }
    }
}
