using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    protected EnemyMoveFactory enemyMoveFactory;
    protected EnemyMoveInfo enemyMoveInfo;
    protected FruitsFactory fruitsFactory;
    protected BulletTemplate fruits;
    protected MaterialFactory materialFactory;
    protected Material material;

    /// <summary>
    /// コンストラクタ
    /// 引数の数字で移動方法、フルーツ、材料を選択する
    /// </summary>
    public Enemy(int moveNum, int fruitsNum, int materialNum)
    {
        this.enemyMoveFactory = new EnemyMoveFactory();
        this.fruitsFactory = new FruitsFactory();
        this.materialFactory = new MaterialFactory();
        this.enemyMoveInfo = this.enemyMoveFactory.SelectEnemyMove(moveNum);
        this.fruits = this.fruitsFactory.SelectFruits(fruitsNum);
        this.material = this.materialFactory.SelectMaterial(materialNum);
    }

    /// <summary>
    /// 以降、各要素を取得するメソッド
    /// </summary>
    /// <returns>それぞれの情報</returns>
    public EnemyMoveInfo GetEnemyMoveInfo()
    {
        return enemyMoveInfo;
    }

    public BulletTemplate GetFruits()
    {
        return fruits;
    }

    public Material GetMaterial()
    {
        return material;
    }
}
