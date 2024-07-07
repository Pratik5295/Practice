using GamePatterns;
using System.Collections.Generic;
using UnityEngine;

public class PizzaGenerator : MonoBehaviour
{
    public List<string> allIngredients = new List<string>();

    private void Start()
    {
        GeneratePizza();
    }

    void GeneratePizza()
    {
        //Create a base
        IPizza pizza = new Pizza();
        PrintIngredients(pizza.GetIngredients());

        //Add Onions
        pizza = new OnionDecorator(pizza);
        PrintIngredients(pizza.GetIngredients());

        //Add Cheese
        pizza = new CheeseDecorator(pizza);
        PrintIngredients(pizza.GetIngredients());

        allIngredients = pizza.GetIngredients();

        Debug.Log("Final Order:");
        PrintIngredients(pizza.GetIngredients());
    }

    private void PrintIngredients(List<string> ingredients)
    {
        int index = 0;
        foreach(var ingredient in ingredients)
        {
            Debug.Log($"{index}: {ingredient}");
            index++;
        }

        Debug.Log("");
    }
}
