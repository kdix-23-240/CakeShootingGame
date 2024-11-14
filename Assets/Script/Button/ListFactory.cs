using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ListFactory
{
    /// <summary>
    /// リストマネージャーを作成するファクトリーメソッド
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public ListManager CreateListManager(int num)
    {
        ListManager listManager = null;
        switch (num)
        {
            case 0:
                listManager = new ShopListManager();
                break;
            case 1:
                listManager = StockListManager.GetInstance();
                break;
            default:
                Debug.Log("選択されたリストが存在しません");
                break;
        }
        return listManager;
    }
}