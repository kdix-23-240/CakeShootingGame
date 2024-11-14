using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCream : Bullet, iTrigger
{
    public override void Move()
    {
        this.cakeList.GetCakeMachineList()[0].GetCream().BulletMove(this, this.pos.y + this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootRange(), this.cakeList.GetCakeMachineList()[0].GetCream().GetShootSpeedX(), this.cakeList.GetCakeMachineList()[0].GetCream().GetShootSpeedY(), this.frameCounter, this.isEnemy);
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
        hp = this.cakeList.GetCakeMachineList()[0].GetCream().Attack(hp);
        collider.gameObject.GetComponent<EnemyMachine>().SetHp(hp);
        if (hp <= 0)
        {
            Destroy(collider.gameObject);
        }
        Destroy(this.gameObject);
    }
}