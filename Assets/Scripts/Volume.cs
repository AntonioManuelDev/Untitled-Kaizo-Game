using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] GameObject soundSlider; 
    [SerializeField] AudioMixer SFXMixer;
    private void Start()
    {
        soundSlider = GameObject.Find("SFXSlider");
        SetVolume(PlayerPrefs.GetFloat("SavedSFXVolume", 100));
    }
    public void SetVolume(float _value) {

        if (_value < 1) {
            _value = .001f;
        }
        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedSFXVolume", _value);
        SFXMixer.SetFloat("SFX Volume", Mathf.Log10(_value / 100) * 20f);
    }
    public void SetVolumeFromSlider()
    {
        SetVolume(soundSlider.GetComponent<Slider>().value);
    }

    public void RefreshSlider(float _value)
    {
        soundSlider.GetComponent<Slider>().value = _value;
    }
}