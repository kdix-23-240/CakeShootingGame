using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cream
{
    protected int power;//弾の威力
    protected float shootRange;//弾の射程
    protected float shootPositionX;//弾の発射位置
    protected float shootPositionY;//弾の発射位置
    protected float shootSpeedX;//弾の速度
    protected float shootSpeedY;//弾の速度
    protected Vector3 pos;

     /// <summary>
    /// 敵機のHPから攻撃力を引いた値を返す
    /// </summary>
    /// <param name="hp">敵機のHP</param>
    /// <param name="attack">自機の攻撃力</param>
    /// <returns>攻撃後の敵機のHP</returns>
    public int Damage(int hp, int attack)
    {
        return hp - attack;
    }
    public abstract void CreamMove(Bullet bullet, float shootRange, float speedX, float speedY);

    public abstract int Attack(int hp);//これいる?

    /// <summary>
    /// 弾の発射位置を指定
    /// </summary>
    /// <returns></returns>
    public int GetPower()
    {
        return power;
    }

    /// <summary>
    /// 弾の射程を指定
    /// </summary>
    /// <returns></returns>
    public float GetShootRange()
    {
        return shootRange;
    }

    /// <summary>
    /// マシンの座標との相対x座標を指定(絶対値)
    /// </summary>
    /// <returns>マシンの座標との相対x座標</returns>
    public float GetShootPositionX()
    {
        return this.shootPositionX;
    }

    /// <summary>
    /// マシンの座標との相対y座標を指定(絶対値)
    /// </summary>
    /// <returns>マシンの座標との相対y座標</returns>
    public float GetShootPositionY()
    {
        return this.shootPositionY;
    }

    /// <summary>
    /// 弾のx軸方向の発射速度を決定
    /// </summary>
    /// <returns>弾のx軸方向の発射速度</returns>
    public float GetShootSpeedX()
    {
        return this.shootSpeedX;
    }

    /// <summary>
    /// 弾のy軸方向の発射速度を決定
    /// </summary>
    /// <returns>弾のy軸方向の発射速度</returns>
    public float GetShootSpeedY()
    {
        return this.shootSpeedY;
    }
}