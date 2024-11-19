using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaSceneChanger : MonoBehaviour
{
    [SerializeField] private string destinationScene;

    void Start()
    {
        //ボタンオブジェクトのテキストにnextSceneNameを表示
        this.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = destinationScene;
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(destinationScene);
    }

    public string GetDestinationScene()
    {
        return this.destinationScene;
    }
}
