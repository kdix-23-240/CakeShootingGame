using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 直進する弾
/// </summary>
public class BulletStraight : BulletTemplate
{
    public override void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy)
    {
        this.StraightMove(bullet, shootRange, speedX, speedY, time, isEnemy);
    }

    /// <summary>
    /// ここに爆弾の処理を書く
    /// </summary>
    private void StraightMove(Bullet bullet, float shootRange, float speedX, float speedY ,float time, bool isEnemy)
    {
        this.pos = bullet.transform.position;
        if(this.JudgeLimitY(isEnemy) || -10.5 > this.pos.x ||this.pos.x > 10.5)//射程外もしくはカメラ外に出たら消す
        {
            GameObject.Destroy(bullet.gameObject);
        }
        this.pos.x += speedX;
        this.pos.y += speedY;
        bullet.transform.position = this.pos;
    }
}