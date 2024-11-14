using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveFactory
{
    /// <summary>
    /// 敵の移動を選択する
    /// </summary>
    /// <param name="num">選択番号</param>
    /// <returns>敵の動き方</returns>
    public EnemyMoveInfo SelectEnemyMove(int num)
    {
        switch(num)
        {
            case 0:
                return new NoMove();
            case 1:
                return new SideStep();
            case 2:
                return new Rotation();
            default:
                Debug.Log("選択された敵の移動が存在しません EnemyMoveFactoryクラスのSelectEnemyMoveメソッド");
                return null;
        }
    }
}