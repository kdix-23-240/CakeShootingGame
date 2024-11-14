using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material
{
    protected int hp;//体力
    protected float speed;//移動速度

    public int GetHp()
    {
        return this.hp;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
    }
}
