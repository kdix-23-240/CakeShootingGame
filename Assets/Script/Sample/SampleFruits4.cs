using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleFruits4 : BulletStraight
{
    public SampleFruits4()
    {
        this.power = 10;//攻撃力
        this.shootRange = 6f;//射程
        this.shootPositionX = 0;//弾の発射位置
        this.shootPositionY = 1f;//弾の発射位置
        this.shootSpeedX = 0.00f;//弾の速度
        this.shootSpeedY = 0.005f;//弾の速度
        this.scaleX = 0.8f;//x軸方向の大きさ
        this.scaleY = 0.8f;//y軸方向の大きさ
        this.isEnemy = false;
    }
}
