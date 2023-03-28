using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckLevelUnlock : MonoBehaviour
{
    public GameObject LockLvl2;

    public GameObject Lock3;

    void Update()
    {
        if (PlayerPrefs.GetInt("TutorialFinish") == 1)
        {
            LockLvl2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level2Finish") == 1)
        {
            Lock3.SetActive(false);
        }
    }
}
