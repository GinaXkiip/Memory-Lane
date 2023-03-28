using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLvl2 : MonoBehaviour
{
    public string MenuScreen;
    public string OtherScenes;

    public void FinishLevel()
    {
        PlayerPrefs.SetInt("Level2Finish", 1);
        print("test");
        SceneManager.LoadScene(MenuScreen);
    }

    public void MoveToOtherScene()
    {
        SceneManager.LoadScene(OtherScenes);
    }
}
