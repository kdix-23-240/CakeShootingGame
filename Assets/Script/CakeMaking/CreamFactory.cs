using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamFactory
{
    /// <summary>
    /// クリームを選択する
    /// ボタンで押されたクリームの番号によって、選択される材料が変わるように変更する
    /// </summary>
    /// <param name="num">選択番号</param>
    /// <returns></returns>
    public BulletTemplate SelectCream(int num)
    {
        switch (num)
        {
            // case 0:
            
            // case 1:

            case 1:
                return new SampleCream1();
            case 2:
                return new SampleCream2();
            default:
                Debug.Log("選択されたクリームが存在しません");
                return null;
        }
    }
}
