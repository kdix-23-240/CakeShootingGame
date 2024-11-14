using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ケーキの材料のボタンを生成するクラス
/// ケーキリストのボタン生成は別のシーンになるのでそれは別クラスで実装
/// </summary>
public class ButtonCreator : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private GameObject parent;
    [SerializeField] private int buttonLine;//ボタンを何行にするか
    [SerializeField] private int buttonSpace;//ボタンとボタンの間隔
    [SerializeField] private int buttonNum;//リストファクトリの番号
    private ListFactory listFactory;
    void Start()
    {
        this.listFactory = new ListFactory();
        this.ArrangeButton();
    }

    /// <summary>
    /// ボタンを生成する
    /// 画面上のボタンを複製する
    /// 
    /// quick hack
    /// 個々のボタンの中身を設定する必要がある
    /// CakeIngredientSelectorのフィールド変数ingredientNameを同クラスのセッターで設定する
    /// このメソッドで生成したオブジェクトでそれをする
    /// </summary>
    public void CreateButton(string name)
    {
        GameObject buttonObj = Instantiate(button);
        ListManager listManager = this.listFactory.CreateListManager(this.buttonNum);
        if (this.buttonNum == 0)
        {
            buttonObj.GetComponent<ShopManager>().SetIngredientName(name);
        }
        else
        {
            buttonObj.GetComponent<CakeIngredientSelector>().SetIngredientName(name);
        }
        buttonObj.transform.SetParent(parent.transform, false);
    }

    /// <summary>
    /// ボタンを配置する
    /// 5つのボタンを一列に並べる
    /// 5つ並べたら次の列に移動する
    /// 
    /// quick hack
    /// ボタンの数が15個(たて3横5)の場合でレイアウト
    /// 条件が変わるとレイアウトが崩れるのでそこの調整をする必要あり
    /// </summary>
    public void ArrangeButton()
    {
        for (int i = 0, j = 0, k = 0; i < this.listFactory.CreateListManager(this.buttonNum).GetContentList().Count && j < buttonLine; i++, k++)
        {
            if (i != 0 && i % (this.listFactory.CreateListManager(this.buttonNum).GetContentList().Count / buttonLine) == 0)
            {
                j++;
                k = 0;
            }
            this.CreateButton(this.listFactory.CreateListManager(this.buttonNum).GetContentName(i));
            try
            {
                parent.transform.GetChild(i).transform.position = new Vector3(
                    parent.transform.position.x - (k * (160 + buttonSpace)) + 400,
                    parent.transform.position.y - (j * (160 + buttonSpace)) + 200,
                    parent.transform.position.z
                );
            }
            catch (System.Exception e)
            {
                Debug.Log(e);
            }
        }
    }
}