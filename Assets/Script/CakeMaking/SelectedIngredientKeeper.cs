using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 選択されたステージを保持するクラス
/// ステージセレクトとかリトライで使う
/// </summary>
public class SelectedIngredientKeeper
{
    private static SelectedIngredientKeeper instance = null;

    private string materialName;
    private string creamName;
    private string fruitsName;
    private SelectedIngredientKeeper()
    {
    }

    /// <summary>
    /// シングルトンパターン
    /// </summary>
    /// <returns></returns>
    public static SelectedIngredientKeeper GetInstance()
    {
        if (instance == null)
        {
            instance = new SelectedIngredientKeeper();
        }
        return instance;
    }

    public void SetMaterialName(string materialName)
    {
        this.materialName = materialName;
    }

    public string GetMaterialName()
    {
        return this.materialName;
    }

    public void SetCreamName(string creamName)
    {
        this.creamName = creamName;
    }

    public string GetCreamName()
    {
        return this.creamName;
    }

    public void SetFruitsName(string frutisName)
    {
        this.fruitsName = frutisName;
    }

    public string GetFruitsName()
    {
        return this.fruitsName;
    }
}