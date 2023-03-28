using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndLv3 : MonoBehaviour
{
    public string EndScreen;
    public string OtherScenes;

    public void FinishLevel()
    {
       
        SceneManager.LoadScene(EndScreen);
    }

    public void MoveToOtherScene()
    {
        SceneManager.LoadScene(OtherScenes);
    }
}
