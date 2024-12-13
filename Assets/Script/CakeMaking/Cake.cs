using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake
{
    private Material material;
    private BulletTemplate cream;
    private BulletTemplate fruits;
    
    public Cake(Material material, BulletTemplate cream, BulletTemplate fruits)
    {
        this.material = material;
        this.cream = cream;
        this.fruits = fruits;
    }

    /// <summary>
    /// 以降、各要素を取得するメソッド
    /// </summary>
    /// <returns></returns>
    public Material GetMaterial()
    {
        return material;
    }

    public BulletTemplate GetCream()
    {
        return cream;
    }

    public BulletTemplate GetFruits()
    {
        return fruits;
    }
}
