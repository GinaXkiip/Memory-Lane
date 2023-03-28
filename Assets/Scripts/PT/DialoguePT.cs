using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguePT : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip Ok;

    public GameObject ObjectToClickOn;
    public GameObject TextToShow;

    public GameObject Lock;

    private void Start()
    {
        TextToShow.SetActive(false);
        Lock.SetActive(true);
    }

    public void OnMouseDown()
    {
        TextToShow.SetActive(true);
    }

    public void CloseText()
    {
        TextToShow.SetActive(false);
        Lock.SetActive(false);
        SFX.clip = Ok;
        SFX.Play();
    }
}
