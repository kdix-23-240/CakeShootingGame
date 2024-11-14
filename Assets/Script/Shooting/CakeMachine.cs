using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMachine : MachineTemplate
{
    [SerializeField] private GameObject bulletFruits;
    [SerializeField] private GameObject bulletCream;
    [SerializeField] private float bulletNumPerSec;
    [SerializeField] private int bulletNumPerOnce;
    [SerializeField] private float bulletDistance;

    private CakeList cakeList;
    private Vector3 pos;//プレイヤーの位置
    private float frameCounter = 0;
    private float bulletCounter = 0;
    void Start()
    {
        this.cakeList = CakeList.GetInstance();
        this.pos = transform.position;
    }

    void Update()
    {
        Move();
        Shoot();
        this.frameCounter += Time.deltaTime;
        this.bulletCounter += Time.deltaTime;
    }

    /// <summary>
    /// WASDで移動する
    /// </summary>
    public override void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("W");
            this.pos.y += this.cakeList.GetCakeMachineList()[0].GetMaterial().GetSpeed();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A");
            this.pos.x -= this.cakeList.GetCakeMachineList()[0].GetMaterial().GetSpeed();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("S");
            this.pos.y -= this.cakeList.GetCakeMachineList()[0].GetMaterial().GetSpeed();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D");
            this.pos.x += this.cakeList.GetCakeMachineList()[0].GetMaterial().GetSpeed();
        }
        this.transform.position = pos;
    }

    /// <summary>
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
            //フルーツ発射
            if (Input.GetKey(KeyCode.Space))
            {
                for (int i = 0; i < bulletNumPerOnce; i++)//一度に何発撃つか
                {
                    GameObject fruitsObj = Instantiate(bulletFruits);
                    fruitsObj.transform.position = new Vector3(this.pos.x + this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootPositionX(), this.pos.y + this.cakeList.GetCakeMachineList()[0].GetFruits().GetShootPositionY() + (bulletDistance * i), this.pos.z);
                    fruitsObj.transform.localScale = new Vector3(this.cakeList.GetCakeMachineList()[0].GetFruits().GetScaleX(), this.cakeList.GetCakeMachineList()[0].GetFruits().GetScaleY(), 1);
                }
                this.frameCounter = 0;
                return;
            }
            GameObject creamObj = Instantiate(bulletCream);
            creamObj.transform.position = new Vector3(this.pos.x + this.cakeList.GetCakeMachineList()[0].GetCream().GetShootPositionX(), this.pos.y + this.cakeList.GetCakeMachineList()[0].GetCream().GetShootPositionY(), this.pos.z);
            creamObj.transform.localScale = new Vector3(this.cakeList.GetCakeMachineList()[0].GetCream().GetScaleX(), this.cakeList.GetCakeMachineList()[0].GetCream().GetScaleY(), 1);
            this.frameCounter = 0;
        }
    }
}
