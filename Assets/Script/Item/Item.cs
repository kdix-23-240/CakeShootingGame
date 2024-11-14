using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private int counter = 0;

    void Start()
    {
        //オブジェクトが生成された時に呼ばれる関数
        Debug.Log("Start");
    }

    //オブジェクトが衝突した時に呼ばれる関数
    void OnTriggerEnter2D(Collider2D collider)
    {
        counter++;
        Debug.Log(counter);
        Destroy(this.gameObject);
    }
}