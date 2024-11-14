using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMachine : MachineTemplate
{
    [SerializeField] private GameObject bulletFruits;
    // [SerializeField] private GameObject bulletCream;
    [SerializeField] private float bulletNumPerSec;
    [SerializeField] private int bulletNumPerOnce;
    [SerializeField] private float bulletDistance;
    private EnemyList enemyList = null;
    private Vector3 pos;//プレイヤーの位置
    private float frameCounter = 0;
    private float bulletCounter = 0;
    [SerializeField] private int listNum;
    private int hp;
    void Start()
    {
        this.enemyList = EnemyList.GetInstance();
        this.pos = transform.position;
        this.hp = this.enemyList.GetEnemyList()[listNum].GetMaterial().GetHp();
    }

    void Update()
    {
        // Move();
        Shoot();
        this.frameCounter += Time.deltaTime;
        this.bulletCounter += Time.deltaTime;
    }

    /// <summary>
    /// WASDで移動する
    /// </summary>
    public override void Move()
    {
        
    }

    /// <summary>
    /// ここで敵の弾を撃つ処理を書く
    /// 弾を撃つ
    /// 
    /// 現状、弾を同時かつ座標をずらして生成している
    /// 理想、弾の生成タイミングをずらして同じ座標に生成する
    /// 
    /// 追記:スケール変更をするにあたり、弾の速射間隔を変更する必要あり
    /// </summary>
    public override void Shoot()
    {
        if (this.frameCounter > 1 / bulletNumPerSec)//1秒間に何回撃つか
        {
            for (int i = 0; i < bulletNumPerOnce; i++)//一度に何発撃つか
            {
                GameObject fruitsObj = Instantiate(bulletFruits);
                fruitsObj.transform.position = new Vector3(this.pos.x + this.enemyList.GetEnemyList()[listNum].GetFruits().GetShootPositionX(), this.pos.y + this.enemyList.GetEnemyList()[listNum].GetFruits().GetShootPositionY() + (bulletDistance * i), this.pos.z);
                fruitsObj.transform.localScale = new Vector3(this.enemyList.GetEnemyList()[listNum].GetFruits().GetScaleX(), this.enemyList.GetEnemyList()[listNum].GetFruits().GetScaleY(), 1);
            }
            this.frameCounter = 0;
        }
    }


    /// <summary>  
    /// ゲッター、セッター
    /// </summary>
    public int GetHp()
    {
        return this.hp;
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
    }
}
