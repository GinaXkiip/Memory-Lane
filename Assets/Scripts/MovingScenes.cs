using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingScenes : MonoBehaviour
{
    public string OtherScenes;

    public void MoveToOtherScene()
    {
        SceneManager.LoadScene(OtherScenes);
    }
}
