using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追跡弾
/// </summary>
public class BulletPersuing : BulletTemplate
{
    /// <summary>
    /// 弾の動き
    /// </summary>
    /// <param name="bullet"></param>
    /// <param name="shootRange"></param>
    /// <param name="speedX"></param>
    /// <param name="speedY"></param>
    /// <param name="time"></param>
    /// <param name="isEnemy"></param>
    public override void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy)
    {
        this.PursuingMove(bullet, shootRange, speedX, speedY, time, isEnemy);
    }

    /// <summary>
    /// ここに爆弾の処理を書く
    /// </summary>
    private void PursuingMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy)
    {
        this.pos = bullet.transform.position;
        if(this.JudgeLimitY(isEnemy) || -10.5 > this.pos.x ||this.pos.x > 10.5)//射程外もしくはカメラ外に出たら消す
        {
            GameObject.Destroy(bullet.gameObject);
        }
        if(0 < time && time < 1f)
        {
            this.pos.x += 0.01f;
            bullet.transform.position = this.pos;
            return;
        }
        this.pos.x += speedX;
        this.pos.y += speedY;
        bullet.transform.position = this.pos;
    }
}