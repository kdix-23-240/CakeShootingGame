using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCream1 : BulletStraight
{
    public SampleCream1()
    {
        this.power = 1;//攻撃力
        this.shootRange = 6f;//射程
        this.shootPositionX = 0;//弾の発射位置
        this.shootPositionY = 1f;//弾の発射位置
        this.shootSpeedX = 0.00f;//弾の速度
        this.shootSpeedY = 0.01f;//弾の速度
        this.scaleX = 0.5f;//x軸方向の大きさ
        this.scaleY = 0.5f;//y軸方向の大きさ
        this.isEnemy = false;
    }
}
