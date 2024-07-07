using GamePatterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(IPizza _pizza) : base(_pizza) { }

    public override List<string> GetIngredients()
    {
        var currentIngredients = pizza.GetIngredients();
        currentIngredients.Add("Mozzarella Cheese");

        return currentIngredients;
    }
}
