using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer _mymixer;
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _sfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVol"))
        {
            LoadVolume();

        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
            SetMasterVolume();
        }


    }

    public void SetMasterVolume()
    {
        float volume = _masterSlider.value;
        _mymixer.SetFloat("master", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MasterVol", volume);

    }

    public void SetMusicVolume()
    {
        float volume = _musicSlider.value;
        _mymixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVol", volume);

    }

    public void SetSFXVolume()
    {
        float volume = _sfxSlider.value;
        _mymixer.SetFloat("soundeff", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVol", volume);
    }

    public void LoadVolume()
    {
        _masterSlider.value = PlayerPrefs.GetFloat("MasterVol");
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        _sfxSlider.value = PlayerPrefs.GetFloat("SFXVol");
       

        SetMasterVolume();
        SetMusicVolume();
        SetSFXVolume();
        
    }
}
