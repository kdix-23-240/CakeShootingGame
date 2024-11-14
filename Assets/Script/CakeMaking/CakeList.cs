using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeList
{
    private List<Cake> cakeMachineList = new List<Cake>();
    private static CakeList cakeList = null;
    
    private CakeList()
    {

    }

    public static CakeList GetInstance()
    {
        if (cakeList == null)
        {
            cakeList = new CakeList();
        }
        return cakeList;
    }

    public void AddCake(Cake cake)
    {
        cakeMachineList.Add(cake);
    }

    public List<Cake> GetCakeMachineList()
    {
        return cakeMachineList;
    }
}
