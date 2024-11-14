using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Button button;
    private string ingredientName;
    private Text buttonText;
    private ListFactory listFactory;

    void Start()
    {
        this.listFactory = new ListFactory();
        buttonText = button.GetComponentInChildren<Text>();
        this.ButtonTextController();
    }

    /// <summary>
    /// 材料の数を表示する
    /// </summary>
    public void ShowListContentName()
    {
        this.ButtonTextController();
    }

    /// <summary>
    /// ボタンのテキストを材料の名前にする
    /// </summary>
    public void ButtonTextController()
    {
        buttonText.text = this.ingredientName;
    }

    public void SetIngredientName(string ingredientName)
    {
        this.ingredientName = ingredientName;
    }
}