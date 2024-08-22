using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeForMusic : MonoBehaviour
{
    [SerializeField] GameObject soundSlider2;
    [SerializeField] AudioMixer MusicMixer;
    private void Start()
    {
        soundSlider2 = GameObject.Find("MusicSlider");
        SetVolume2(PlayerPrefs.GetFloat("SavedMusicVolume", 100));
    }
    public void SetVolume2(float _value)
    {

        if (_value < 1)
        {
            _value = .001f;
        }
        RefreshSlider2(_value);
        PlayerPrefs.SetFloat("SavedMusicVolume", _value);
        MusicMixer.SetFloat("Music Volume", Mathf.Log10(_value / 100) * 20f);
    }
    public void SetVolumeFromSlider2()
    {
        SetVolume2(soundSlider2.GetComponent<Slider>().value);
    }

    public void RefreshSlider2(float _value)
    {
        soundSlider2.GetComponent<Slider>().value = _value;
    }
}