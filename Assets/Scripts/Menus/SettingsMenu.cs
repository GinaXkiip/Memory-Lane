using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip Ok;

    public GameObject ResetScreen;

    public AudioMixer TheMixer;
    public TMP_Text MasterLabel, MusicLabel, SFXLabel;
    public Slider MasterSlider, MusicSlider, SFXSlider;

    void Start()
    {
        float Volume = 0f;
        TheMixer.GetFloat("MasterVolume", out Volume);
        MasterSlider.value = Volume;
        TheMixer.GetFloat("MusicVolume", out Volume);
        MusicSlider.value = Volume;
        TheMixer.GetFloat("SFXVolume", out Volume);
        SFXSlider.value = Volume;

        MasterLabel.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();
        MusicLabel.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();
        SFXLabel.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();
    }


    public void SetMasterVolume()
    {
        MasterLabel.text = Mathf.RoundToInt(MasterSlider.value + 80).ToString();

        TheMixer.SetFloat("MasterVolume", MasterSlider.value);

        PlayerPrefs.SetFloat("MasterVolume", MasterSlider.value);
    }
    public void SetMusicVolume()
    {
        MusicLabel.text = Mathf.RoundToInt(MusicSlider.value + 80).ToString();

        TheMixer.SetFloat("MusicVolume", MusicSlider.value);

        PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
    }

    public void SetSFXVolume()
    {
        SFXLabel.text = Mathf.RoundToInt(SFXSlider.value + 80).ToString();

        TheMixer.SetFloat("SFXVolume", SFXSlider.value);

        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }

    public void SFXSoundEffect()
    {
        SFX.clip = Ok;
        SFX.Play();
    }

    public void OpenReset()
    {
        ResetScreen.SetActive(true);
        SFX.clip = Ok;
        SFX.Play();
    }

    public void CloseReset()
    {
        ResetScreen.SetActive(false);
        SFX.clip = Ok;
        SFX.Play();
    }
}



