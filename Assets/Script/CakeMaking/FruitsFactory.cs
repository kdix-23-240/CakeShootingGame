using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsFactory
{
    /// <summary>
    /// フルーツを選択する
    /// ボタンで押されたフルーツの番号によって、選択される材料が変わるように変更する
    /// </summary>
    /// <param name="num">選択番号</param>
    /// <returns></returns>
    public BulletTemplate SelectFruits(int num)
    {
        switch (num)
        {
            case -1:
                return new SampleEnemyFruits();
            // case 0:

            // case 1:

            case 2:
                return new SampleFruits3();
            case 3:
                return new SampleFruits4();
            case 4:
                return new SampleFruits5();
            case 99:
                return new SampleFruitsB();
            default:
                Debug.Log("選択されたフルーツが存在しません");
                return null;
        }
    }
}
