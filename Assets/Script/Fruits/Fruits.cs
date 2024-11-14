using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Ingredient
{
    //Ingredientクラスを作ったためこのクラスの存在意義が.......
    public Fruits(string fruitsName, int fruitsPrice, int identificationNumber)
    {
        this.ingredientName = fruitsName;
        this.ingredientPrice = fruitsPrice;
        this.identificationNumber = identificationNumber;
    }
}