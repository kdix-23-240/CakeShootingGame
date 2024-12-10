using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected CakeList cakeList;
    protected Vector3 pos;
    protected float frameCounter;
    protected bool isEnemy;
    private KilledEnemyNum killedEnemyNum = KilledEnemyNum.GetInstance();

    void Start()
    {
        this.cakeList = CakeList.GetInstance();
        this.pos = transform.position;
        this.frameCounter = 0;
        this.isEnemy = false;
    }

    void Update()
    {
        this.Move();
        this.frameCounter += Time.deltaTime;
    }

    public abstract void Move();

    /// <summary>
    /// 当たり判定
    /// ダメージ計算とオブジェクトの削除
    /// </summary>
    /// <param name="collider">弾に当たったもののオブジェクト</param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        int hp = collider.gameObject.GetComponent<EnemyMachine>().GetHp();
        hp = this.cakeList.GetCakeMachineList()[0].GetCream().Attack(hp);
        collider.gameObject.GetComponent<EnemyMachine>().SetHp(hp);
        if (hp <= 0)
        {
            Destroy(collider.gameObject);
            this.killedEnemyNum.AddKilledEnemyNum();
        }
        Destroy(this.gameObject);
    }
}