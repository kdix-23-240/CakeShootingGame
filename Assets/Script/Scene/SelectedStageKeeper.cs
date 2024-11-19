using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 選択されたステージを保持するクラス
/// ステージセレクトとかリトライで使う
/// </summary>
public class SelectedStageKeeper
{
    private static SelectedStageKeeper instance = null;

    private string selectedStage;
    private SelectedStageKeeper()
    {
    }

    /// <summary>
    /// シングルトンパターン
    /// </summary>
    /// <returns></returns>
    public static SelectedStageKeeper GetInstance()
    {
        if (instance == null)
        {
            instance = new SelectedStageKeeper();
        }
        return instance;
    }

    public void SetSelectedStage(string stage)
    {
        selectedStage = stage;
    }

    public string GetSelectedStage()
    {
        return selectedStage;
    }
}