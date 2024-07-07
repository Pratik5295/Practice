using System.Collections.Generic;

namespace GamePatterns
{
    public class OnionDecorator : PizzaDecorator
    {
        //Inject into the base decorator
        public OnionDecorator(IPizza pizza) : base(pizza) { }


        public override List<string> GetIngredients()
        {
            var ingredients = pizza.GetIngredients();
            ingredients.Add("Onions");
            return ingredients;
        }
    }
}
