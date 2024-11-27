using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilledEnemyNum
{
    private int killedEnemyNum = 0;
    private static KilledEnemyNum instance;

    private KilledEnemyNum(){}

    public static KilledEnemyNum GetInstance()
    {
        if (instance == null)
        {
            instance = new KilledEnemyNum();
        }
        return instance;
    }

    public void AddKilledEnemyNum()
    {
        this.killedEnemyNum++;
    }

    public int GetKilledEnemyNum()
    {
        return this.killedEnemyNum;
    }

    public void ResetKilledEnemyNum()
    {
        this.killedEnemyNum = 0;
    }
}