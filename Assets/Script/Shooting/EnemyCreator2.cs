using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator2 : EnemyManager
{
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;

    void Start()
    {
        this.enemyList = new List<GameObject>();
        enemyList.Add(this.enemy1);
        enemyList.Add(this.enemy2);
        this.CreateEnemy(this.enemyList);
    }
}
