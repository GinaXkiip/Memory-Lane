using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingScenesTwo : MonoBehaviour
{
    public string OtherScene1;
    public string OtherScene2;

    public void MoveToOtherSceneBack()
    {
        SceneManager.LoadScene(OtherScene1);
    }

    public void MoveToOtherSceneNext()
    {
        SceneManager.LoadScene(OtherScene2);
    }
}
