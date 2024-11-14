using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCream4 : BulletPersuing
{
    public SampleCream4()
    {
        this.power = 3;//攻撃力
        this.shootRange = 6f;//射程
        this.shootPositionX = 1f;//弾の発射位置
        this.shootPositionY = 0f;//弾の発射位置
        this.shootSpeedX = 0.00f;//弾の速度
        this.shootSpeedY = 0.01f;//弾の速度
        this.scaleX = 0.3f;//x軸方向の大きさ
        this.scaleY = 0.7f;//y軸方向の大きさ
        this.isEnemy = false;
    }
}
