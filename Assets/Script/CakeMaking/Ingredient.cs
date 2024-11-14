using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    protected string ingredientName;
    protected int ingredientPrice;
    protected int identificationNumber;

    public string GetIngredientName()
    {
        return ingredientName;
    }

    public int GetIngredientPrice()
    {
        return ingredientPrice;
    }

    public int GetIdentificationNumber()
    {
        return identificationNumber;
    }
}
