using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTemplate : MonoBehaviour
{
    [SerializeField] private string buttonName;

    void Start()
    {
        //ボタンオブジェクトのテキストにnextSceneNameを表示
        this.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = this.buttonName;
    }
}
