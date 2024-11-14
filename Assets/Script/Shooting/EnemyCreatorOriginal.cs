using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreatorOriginal : EnemyManager
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int enemyNum;
    
    void Start()
    {
        this.enemyList = new List<GameObject>();
        for (int i = 0; i < this.enemyNum; i++)
        {
            this.enemyList.Add(this.enemy);
        }
        this.CreateEnemy(this.enemyList);
    }
}
