using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DecideCakeIngredient : MonoBehaviour
{

    private string materialName;
    private string creamName;
    private string frutisName;
    private CakeMaker cakeMaker;
    public void OnClick()
    {
        Decide();
    }

    private void Decide()
    {
        this.materialName = SelectedIngredientKeeper.GetInstance().GetMaterialName();
        this.creamName = SelectedIngredientKeeper.GetInstance().GetCreamName();
        this.frutisName = SelectedIngredientKeeper.GetInstance().GetFruitsName();

        if (this.materialName != null && this.creamName != null && this.frutisName != null)
        {
            SceneManager.LoadScene(SelectedStageKeeper.GetInstance().GetSelectedStage());
            this.cakeMaker = new CakeMaker(IngNameToIngNumChanger.ChangeIngNameToIngNum(this.materialName), IngNameToIngNumChanger.ChangeIngNameToIngNum(this.creamName), IngNameToIngNumChanger.ChangeIngNameToIngNum(this.frutisName));
            this.cakeMaker.MakeCake();
        }else{
            Debug.Log("you have to select all ingredients");
            Debug.Log("materialName: " + this.materialName);
            Debug.Log("creamName: " + this.creamName);
            Debug.Log("frutisName: " + this.frutisName);
        }
    }
}