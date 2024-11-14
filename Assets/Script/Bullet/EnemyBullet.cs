using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet, iTrigger
{
    private EnemyList enemyList;
    void Start()
    {
        this.enemyList = EnemyList.GetInstance();
        this.cakeList = CakeList.GetInstance();
        this.pos = transform.position;
        this.frameCounter = 0;
        this.isEnemy = true;
    }

    void Update()
    {
        Move();
        this.frameCounter += Time.deltaTime;
    }

    public override void Move()
    {
        this.enemyList.GetEnemyList()[0].GetFruits().BulletMove(this, this.pos.y - this.enemyList.GetEnemyList()[0].GetFruits().GetShootRange(), this.enemyList.GetEnemyList()[0].GetFruits().GetShootSpeedX(), this.enemyList.GetEnemyList()[0].GetFruits().GetShootSpeedY(), this.frameCounter, this.isEnemy);
    }

    /// <summary>
    /// 当たり判定
    /// ダメージ計算とオブジェクトの削除
    /// </summary>
    /// <param name="collider">弾に当たったもののオブジェクト</param>
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Player") return;
        int hp = cakeList.GetCakeMachineList()[0].GetMaterial().GetHp();
        hp = this.enemyList.GetEnemyList()[0].GetFruits().Attack(hp);
        cakeList.GetCakeMachineList()[0].GetMaterial().SetHp(hp);
        if (hp <= 0)
        {
            Destroy(collider.gameObject);
        }
        Destroy(this.gameObject);
    }
}
