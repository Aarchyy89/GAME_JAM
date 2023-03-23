using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voluyme_Manager : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image mute_img;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume", 0.5f);
        AudioListener.volume = slider.value;
        Mute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("Volume", sliderValue);
        AudioListener.volume = slider.value;
        Mute(); 

                        
    }

    public void Mute()
    {
        if(sliderValue == 0)
        {
            mute_img.enabled = true;
        }
        else
        {
            mute_img.enabled = false;
        }
    }
}
