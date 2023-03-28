using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public string Levelpre1;
    public string Level1;
    public string Level2;
    public string Level3;

    public string BackToMenu;

    public void StartLevel1()
    {
        if (PlayerPrefs.GetInt("PTPuzzlePiece") == 1)
        {
            SceneManager.LoadScene(Level1);
        }

        if (PlayerPrefs.GetInt("PTPuzzlePiece") == 0)
        {
            SceneManager.LoadScene(Levelpre1);
        }
    }
    public void StartLevel2()
    {
        SceneManager.LoadScene(Level2);
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene(Level3);
    }

    public void BackToStartMenu()
    {
        SceneManager.LoadScene(BackToMenu);
    }
}
