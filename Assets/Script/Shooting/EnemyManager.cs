using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    protected List<GameObject> enemyList;
    /// <summary>
    /// 敵の生成
    /// </summary>
    public void CreateEnemy(List<GameObject> enemyList)
    {
        int i = 0;
        if (this.enemyList.Count % 2 == 0)
        {
            foreach (GameObject enemy in this.enemyList)
            {
                if (i % 2 == 0)
                {
                    GameObject enemyObject = Instantiate(enemyList[i]);
                    enemyObject.transform.position = new Vector2((1.5f * (i + 1)), 2);
                    enemyObject.transform.localScale = new Vector2(1, 1);
                }
                else if (i % 2 == 1)
                {
                    GameObject enemyObject = Instantiate(enemyList[i]);
                    enemyObject.transform.position = new Vector2( -1 * (1.5f * i), 2);
                    enemyObject.transform.localScale = new Vector2(1, 1);
                }
                i++;
            }
        }
        else if (this.enemyList.Count % 2 == 1)
        {
            foreach (GameObject enemy in this.enemyList)
            {
                if (i % 2 == 0)
                {
                    GameObject enemyObject = Instantiate(enemyList[i]);
                    enemyObject.transform.position = new Vector2(i, 2);
                    enemyObject.transform.localScale = new Vector2(1, 1);
                }
                else if (i % 2 == 1)
                {
                    GameObject enemyObject = Instantiate(enemyList[i]);
                    enemyObject.transform.position = new Vector2(-1 * (i + 1), 2);
                    enemyObject.transform.localScale = new Vector2(1, 1);
                }
                i++;
            }
        }
    }
}