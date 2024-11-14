using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator5 : EnemyManager
{
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;
    [SerializeField] private GameObject enemy4;
    [SerializeField] private GameObject enemy5;

    void Start()
    {
        this.enemyList = new List<GameObject>();
        enemyList.Add(this.enemy1);
        enemyList.Add(this.enemy2);
        enemyList.Add(this.enemy3);
        enemyList.Add(this.enemy4);
        enemyList.Add(this.enemy5);
        this.CreateEnemy(this.enemyList);
    }
}
