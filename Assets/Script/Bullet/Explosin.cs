using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosin : MonoBehaviour
{
    private CakeList cakeList;
    private bool isExplosion = false;
    private KilledEnemyNum killedEnemyNum = KilledEnemyNum.GetInstance();
    // Start is called before the first frame update
    void Start()
    {
        cakeList = CakeList.GetInstance();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Enemy" || isExplosion) return;

        int hp = collider.gameObject.GetComponent<EnemyMachine>().GetHp();
        hp = this.cakeList.GetCakeMachineList()[0].GetFruits().Attack(hp);
        collider.gameObject.GetComponent<EnemyMachine>().SetHp(hp);
        if (hp <= 0)
        {
            Destroy(collider.gameObject);
            this.killedEnemyNum.AddKilledEnemyNum();
        }
        Debug.Log("Explosion");
        isExplosion = true;
    }
}
