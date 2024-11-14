using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 反射弾
/// </summary>
public class BulletBounce : BulletTemplate
{
    public override void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy)
    {
        this.BounceMove(bullet, shootRange, speedX, speedY, isEnemy);
    }

    /// <summary>
    /// ここに跳ねる弾の処理を書く
    /// </summary>
    private void BounceMove(Bullet bullet, float shootRange, float speedX, float speedY, bool isEnemy)
    {
        
    }
}