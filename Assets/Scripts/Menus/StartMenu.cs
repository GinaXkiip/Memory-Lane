using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip Ok;

    public string MainGame;

    public GameObject SettingsScreen;


    public void StartGame()
    {
        SceneManager.LoadScene(MainGame);
    }


    public void OpenSettings()
    {
        SettingsScreen.SetActive(true);
        SFX.clip = Ok;
        SFX.Play();
    }

    public void CloseSettings()
    {
        SettingsScreen.SetActive(false);
        SFX.clip = Ok;
        SFX.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Quit");
    }
}
