using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator3 : EnemyManager
{
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;

    void Start()
    {
        this.enemyList = new List<GameObject>();
        enemyList.Add(this.enemy1);
        enemyList.Add(this.enemy2);
        enemyList.Add(this.enemy3);
        this.CreateEnemy(this.enemyList);
    }
}
