using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueDisplay : MonoBehaviour

{
    public AudioSource SFX;
    public AudioClip Ok;

   public GameObject ObjectToClickOn;
   public GameObject TextToShow;

    private void Start()
    {
        TextToShow.SetActive(false);
    }

    public void OnMouseDown()
    {
        TextToShow.SetActive(true);
    }

    public void CloseText()
    {
        TextToShow.SetActive(false);
        SFX.clip = Ok;
        SFX.Play();
    }
}
