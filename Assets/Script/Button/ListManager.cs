using System.Collections;
using System.Collections.Generic;

/// <summary>
/// フルーツのリストを管理するクラス(現状)
/// もしかしたら生地、フルーツ、クリームだけじゃなくケーキリストの編集もできるかも
/// (追記(思いつき))このクラスを抽象クラスにして、生地、フルーツ、クリーム、ケーキの具象クラスで属性だけ決めるでもいいかも
/// </summary>
public abstract class ListManager
{
    protected List<List<string>> contentList;

    public ListManager()
    {
        this.contentList = new List<List<string>>();
    }

    /// <summary>
    /// 一種類のフルーツを登録する
    /// </summary>
    /// <param name="name">登録するフルーツの名前</param>
    /// <param name="num">登録する数</param>
    /// <param name="content">一種類のフルーツのリスト</param>
    public void RegisterContent(string name, int num)
    {
        num++;//numが0の時にfor文が回らないので1足す
        List<string> content = new List<string>();
        for (int i = 0; i < num; i++)
        {
            content.Add(name);
        }
        this.contentList.Add(content);
    }

    /// <summary>
    /// フルーツリストから指定したフルーツを追加する
    /// </summary>
    /// <param name="name">フルーツの名前</param>
    /// <param name="num">追加するフルーツの数</param>
    public void AddContent(string name, int num)
    {
        foreach (List<string> content in this.contentList)
        {
            if (content.Contains(name))
            {
                for (int i = 0; i < num; i++)
                {
                    content.Add(name);
                }
            }
        }
    }

    /// <summary>
    /// フルーツリストから指定したフルーツを削除する
    /// </summary>
    /// <param name="name">削除するフルーツの名前</param>
    /// <param name="num">削除する数</param>
    public void DeleteContent(string name, int num)
    {
        foreach (List<string> content in this.contentList)
        {
            if (content.Contains(name))
            {
                for (int i = 0; i < num; i++)
                {
                    if(content.Count == 1)
                    {
                        break;
                    }
                    content.Remove(name);
                }
            }
        }
    }
    
     /// <summary>
    /// フルーツリストから指定したフルーツの名前からフルーツの数を検索する
    /// </summary>
    /// <param name="name">指定したフルーツの名前</param>
    /// <returns>フルーツの数</returns>
    public string ShowListContentNum(string name)
    {
        foreach(List<string> content in contentList)
        {
            if(content.Contains(name))
            {
                // return content[1];
                return (content.Count - 1).ToString();
            }
        }
        return "null";
    }

    public List<List<string>> GetContentList()
    {
        return this.contentList;
    }

    public string GetContentName(int num)
    {
        return this.contentList[num][0];
    }

    public int GetContentNum(int num)
    {
        return this.contentList[num].Count;
    }
}