using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSceneChanger : MonoBehaviour
{
    [SerializeField] private string destinationScene;

    void Start()
    {
        //ボタンオブジェクトのテキストにnextSceneNameを表示
        this.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = destinationScene;
    }

    public void GoToScene()
    {
        SelectedStageKeeper.GetInstance().SetSelectedStage(this.destinationScene);
        // SceneManager.LoadScene("MachineSelect");
        SceneManager.LoadScene("IngredientSelect");
    }

    public string GetDestinationScene()
    {
        return this.destinationScene;
    }
}
