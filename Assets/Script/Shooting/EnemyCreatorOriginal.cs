using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreatorOriginal : EnemyManager
{
    [SerializeField] private int minEnemyNum;
    [SerializeField] private int maxEnemyNum;
    private int enemyNum;
    private KilledEnemyNum killedEnemyNum = KilledEnemyNum.GetInstance();
    
    void Start()
    {
        this.enemyNum = Random.Range(minEnemyNum, maxEnemyNum + 1);
        for (int i = 0; i < this.enemyNum; i++)
        {
            CreateEnemy();
        }
    }

    void Update()
    {
        if(killedEnemyNum.GetKilledEnemyNum() != this.enemyNum) return;

        this.enemyPosList = new List<int> { -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 };
        Debug.Log("Create Enemy");
        this.enemyNum = Random.Range(minEnemyNum, maxEnemyNum + 1);
        for (int i = 0; i < this.enemyNum; i++)
        {
            CreateEnemy();
        }
        killedEnemyNum.ResetKilledEnemyNum();
    }
}
