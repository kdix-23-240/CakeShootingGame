using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFruits : Bullet, iTrigger
{
    public override void Move()
    {
        this.cakeList.GetCakeMachineList()[0].GetFruits().BulletMove(this, this.pos.y + this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootRange(), this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootSpeedX(), this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootSpeedY(), this.frameCounter, this.isEnemy);
        if(this.frameCounter > 3.0f)
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// 当たり判定
    /// ダメージ計算とオブジェクトの削除
    /// </summary>
    /// <param name="collider">弾に当たったもののオブジェクト</param>
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Enemy") return;
        int hp = collider.gameObject.GetComponent<EnemyMachine>().GetHp();
        hp = this.cakeList.GetCakeMachineList()[0].GetFruits().Attack(hp);
        collider.gameObject.GetComponent<EnemyMachine>().SetHp(hp);
        if (hp <= 0)
        {
            Destroy(collider.gameObject);
        }
        Destroy(this.gameObject);
    }
}