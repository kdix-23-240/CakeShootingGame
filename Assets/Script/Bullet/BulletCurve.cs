using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCurve : BulletTemplate
{
    Vector3 halfway = new Vector3(3f, 0.3f, 0);
    Vector3 enemyPos = new Vector3(0.04f, 2.53f, 0);
    public override void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY, float time, bool isEnemy)
    {
        this.CurveMove(bullet, shootRange, speedX, speedY, time);
    }

    /// <summary>
    /// ここに爆弾の処理を書く
    /// </summary>
    private void CurveMove(Bullet bullet, float shootRange, float speedX, float speedY, float time)
    {
        var a = Vector3.Slerp(bullet.transform.position, halfway, time);
        var b = Vector3.Slerp(halfway, enemyPos, time);

        bullet.transform.position = Vector3.Slerp(a, b, time);
    }
}