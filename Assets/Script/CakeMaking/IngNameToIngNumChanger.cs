using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngNameToIngNumChanger
{
    public static int ChangeIngNameToIngNum(string name)
    {
        switch (name.Substring(name.Length - 1))
        {
            case "1":
                return 1;
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5": 
                return 5;
            case "B":    
                return 99;
            default:
                return -1;
        }
    }
}
