using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFactory
{
    /// <summary>
    /// 材料を選択するメソッド
    /// ボタンで押された生地の番号によって、選択される材料が変わるように変更する
    /// </summary>
    /// <param name="num">選択番号</param>
    /// <returns></returns>
    public Material SelectMaterial(int num)
    {
        switch (num)
        {
            case 1:
                return new SampleMaterial1();
            case 2:
                return new SampleMaterial2();
            default:
                Debug.Log("選択された生地が存在しません");
                return null;
        }
    }
}
