using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMachineSelecter : MonoBehaviour
{
    [SerializeField] private int materialNum;
    [SerializeField] private int creamNum;
    [SerializeField] private int fruitsNum;
    private CakeMaker cakeMaker;

    public void OnClick()
    {
        SceneManager.LoadScene("Shooting");
        this.cakeMaker = new CakeMaker(materialNum, creamNum, fruitsNum);
        this.cakeMaker.MakeCake();
    }
}