using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// フルーツのリストを管理するクラス(現状)
/// もしかしたら生地、フルーツ、クリームだけじゃなくケーキリストの編集もできるかも
/// (追記(思いつき))このクラスを抽象クラスにして、生地、フルーツ、クリーム、ケーキの具象クラスで属性だけ決めるでもいいかも
/// </summary>
public class StockListManager : ListManager
{
    private static StockListManager instance = null;
    private StockListManager()
    {
        this.RegisterContent("strawberry", 10);
        this.RegisterContent("blueberry", 8);
        this.RegisterContent("melon", 5);
        this.RegisterContent("apple", 6);
        this.RegisterContent("orange", 0);
        this.RegisterContent("cherry", 2);
        this.RegisterContent("peach", 5);
        this.RegisterContent("grape", 10);
        this.RegisterContent("banana", 3);
        this.RegisterContent("mango", 0);
        this.RegisterContent("kiwi", 1);
        this.RegisterContent("lemon", 3);
        this.RegisterContent("watermelon", 0);
        this.RegisterContent("lychee", 5);
        this.RegisterContent("persimmon", 10);
    }

    /// <summary>
    /// シングルトンパターン
    /// </summary>
    /// <returns></returns>
    public static StockListManager GetInstance()
    {
        if (instance == null)
        {
            instance = new StockListManager();
        }
        return instance;
    }
}