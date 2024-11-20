using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList
{
    private List<Enemy> enemyList = new List<Enemy>();
    private static EnemyList instance = null;
    /// <summary>
    /// コンストラクタ
    /// シングルトンパターン
    /// </summary>
    private EnemyList()
    {
        AddEnemy(new Enemy(0, -1, 1));
    }
    public static EnemyList GetInstance()
    {
        if (instance == null)
        {
            instance = new EnemyList();
        }
        return instance;
    }

    /// <summary>
    /// 敵を追加する
    /// </summary>
    /// <param name="enemy">追加する敵機の情報</param>
    private void AddEnemy(Enemy enemy)
    {
        enemyList.Add(enemy);
    }

    /// <summary>
    /// 敵リストを取得する
    /// </summary>
    public List<Enemy> GetEnemyList()
    {
        return enemyList;
    }
}
