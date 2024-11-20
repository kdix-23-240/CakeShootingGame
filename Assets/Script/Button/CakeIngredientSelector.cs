using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CakeIngredientSelector : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private string ingredientName;
    private Text buttonText;
    private ListFactory listFactory;

    void Start()
    {
        this.listFactory = new ListFactory();
        buttonText = button.GetComponentInChildren<Text>();
    }

    /// <summary>
    /// 材料の数をカウントする
    /// </summary>
    public void CountIngredientNum()
    {
        this.listFactory.CreateListManager(1).DeleteContent(this.ingredientName, 1);
        this.ButtonTextController(this.ingredientName);
    }

    public void SelectMaterial()
    {
        SelectedIngredientKeeper.GetInstance().SetMaterialName(this.ingredientName);
        this.ButtonTextController(this.ingredientName);
    }

    public void SelectCream()
    {
        SelectedIngredientKeeper.GetInstance().SetCreamName(this.ingredientName);
        this.ButtonTextController(this.ingredientName);
    }

    public void SelectFruits()
    {
        SelectedIngredientKeeper.GetInstance().SetFruitsName(this.ingredientName);
        this.ButtonTextController(this.ingredientName);
    }

    /// <summary>
    /// ボタンのテキストを材料の名前にする
    /// </summary>

    public void ButtonTextController(string str)
    {
        buttonText.text = this.ingredientName + "\n" + this.listFactory.CreateListManager(1).ShowListContentNum(this.ingredientName);
    }

    public void SetIngredientName(string ingredientName)
    {
        this.ingredientName = ingredientName;
    }
}