using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletTemplate
{
    protected int power;//攻撃力
    protected float shootRange;//射程
    protected float shootPositionX;//弾の発射位置
    protected float shootPositionY;//弾の発射位置
    protected float shootSpeedX;//弾の速度
    protected float shootSpeedY;//弾の速度

    protected float scaleX;//x軸方向の大きさ
    protected float scaleY;//y軸方向の大きさ
    protected Vector3 pos;
    protected bool isEnemy;

    /// <summary>
    /// 敵機のHPから攻撃力を引いた値を返す
    /// </summary>
    /// <param name="hp">敵機のHP</param>
    /// <param name="attack">自機の攻撃力</param>
    /// <returns>攻撃後の敵機のHP</returns>

    public int Damage(int hp)
    {
        Debug.Log(this.power);
        return hp - this.power;
    }

    /// <summary>
    /// BulletFruits,BulletCreamのUpdate関数で呼び出し
    /// </summary>
    public abstract void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy);

    /// <summary>
    /// 敵機のHPから攻撃力を引いた値を返す
    /// これ使うと思ったのにマジでいらんかった
    /// 大反省
    /// </summary>
    /// <param name="hp"></param>
    /// <returns></returns>

    public int Attack(int hp)
    {
        return this.Damage(hp);
    }

    /// <summary>
    /// 弾が射程外に出たかどうかを判定
    /// 敵かどうかで判定が異なる
    /// </summary>
    /// <param name="isEnemy"></param>
    /// <returns>弾が破壊されるy軸方向の範囲</returns>
    public bool JudgeLimitY(bool isEnemy)
    {
        if (this.isEnemy)
        {
            return (this.pos.y < -shootRange || this.pos.y < -5.5f);
        }
        else
        {
            return (this.pos.y > shootRange || this.pos.y > 5.5f);
        }
    }

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

    /// <summary>
    /// 弾のx軸方向の大きさを指定
    /// </summary>
    /// <returns></returns>
    public float GetScaleX()
    {
        return scaleX;
    }

    /// <summary>
    /// 弾のy軸方向の大きさを指定
    /// </summary>
    /// <returns></returns>
    public float GetScaleY()
    {
        return scaleY;
    }
}
