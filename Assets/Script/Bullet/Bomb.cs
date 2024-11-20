using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Bullet
{
    [SerializeField] private GameObject bulletBomb;//爆発オブジェクト

    public override void Move()
    {
        this.cakeList.GetCakeMachineList()[0].GetFruits().BulletMove(this, this.pos.y + this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootRange(), this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootSpeedX(), this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootSpeedY(), this.frameCounter, this.isEnemy);
        if (this.frameCounter > 3.0f)
        {
            Destroy(this.gameObject);
        }
    }
    
    /// <summary>
    /// 当たり判定
    /// ダメージ計算とオブジェクトの削除
    /// </summary>
    /// <param name="collider">弾に当たったもののオブジェクト</param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Enemy") return;
        pos = this.transform.position;
        //レンダリングの都合的に爆発範囲が大きい方から
        GameObject bombObj1 = Instantiate(bulletBomb);
        bombObj1.transform.position = new Vector3(this.pos.x, this.pos.y, this.pos.z);
        bombObj1.transform.localScale = new Vector3(2, 2, 1);

        GameObject bombObj2 = Instantiate(bulletBomb);
        bombObj2.transform.position = new Vector3(this.pos.x, this.pos.y, this.pos.z);
        bombObj2.transform.localScale = new Vector3(1, 1, 1);

        Destroy(this.gameObject);
        Destroy(bombObj1, 0.5f);
        Destroy(bombObj2, 0.5f);
    }
}