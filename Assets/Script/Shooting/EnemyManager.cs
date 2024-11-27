using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    protected List<GameObject> enemyList;
    protected List<int> enemyPosList = new List<int> { -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7 };
    /// <summary>
    /// 敵の生成
    /// </summary>
    public void CreateEnemy()
    {
       int randomXPos = Random.Range(-7, 8);
        if (this.enemyPosList.Contains(randomXPos))
        {
            float randomYPos = Random.Range(0, 100) * 0.01f;
            GameObject enemyObject = Instantiate(this.enemy);
            enemyObject.transform.position = new Vector2(randomXPos, randomYPos);
            enemyObject.transform.localScale = new Vector2(1, 1);

            this.enemyPosList.Remove(randomXPos);
        }
        else
        {
            CreateEnemy();
        } 
    }
}