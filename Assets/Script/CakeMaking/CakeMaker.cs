using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMaker
{
    // private int materialNum;
    // private int creamNum;
    // private int fruitsNum;
    private int materialNum;
    private int creamNum;
    private int fruitsNum;
    private MaterialFactory materialFactory;
    private CreamFactory creamFactory;
    private FruitsFactory fruitsFactory;
    private CakeList cakeList;

    public CakeMaker(int materialNum, int creamNum, int fruitsNum)
    {
        this.materialNum = materialNum;
        this.creamNum = creamNum;
        this.fruitsNum = fruitsNum;

        materialFactory = new MaterialFactory();
        creamFactory = new CreamFactory();
        fruitsFactory = new FruitsFactory();
        cakeList = CakeList.GetInstance();
    }

    /// <summary>
    /// 生地、クリーム、フルーツを指定してケーキを作る
    /// </summary>
    public void MakeCake()
    {
        Material material = materialFactory.SelectMaterial(this.materialNum);
        BulletTemplate cream = creamFactory.SelectCream(this.creamNum);
        BulletTemplate fruits = fruitsFactory.SelectFruits(this.fruitsNum);

        cakeList.AddCake(new Cake(material, cream, fruits));
    }
}
