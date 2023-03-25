using UnityEngine;
using UnityEngine.UI;

public class Voluyme_Manager : MonoBehaviour
{
    [Header("musica")] public Slider sliderMusica;
    public float slidervalueMusica;
    public Image imgMuteMusica;
    public AudioSource sourceMusica;

    [Header("sonido")] public Slider sliderSoindos;
    public float slidervalueSonidos;
    public Image imgMuteSonidos;
    public AudioSource sourceSonidos;

    void Start()
    {
        sliderMusica.value = PlayerPrefs.GetFloat("volmenMusica", 0.5f);
        sourceMusica.volume = sliderMusica.value;
        musicaMute();
        
        sliderSoindos.value = PlayerPrefs.GetFloat("volmenSonidos", 0.5f);
        sourceSonidos.volume = sliderSoindos.value;
        sonidosMute();
    }

    public void slidermusica(float valorMusica)
    {
        slidervalueMusica = valorMusica;
        PlayerPrefs.SetFloat("volmenMusica", slidervalueMusica);
        sourceMusica.volume = sliderMusica.value;
        musicaMute();
        
    }
    
    public void slidersonidos(float valorSonidos)
    {
        slidervalueSonidos = valorSonidos;
        PlayerPrefs.SetFloat("volmenSonidos", slidervalueSonidos);
        sourceSonidos.volume = sliderSoindos.value;
        sonidosMute();
        
    }

    public void musicaMute()
    {
        if (slidervalueMusica == 0)
        {
            imgMuteMusica.enabled = true;
        }
        else
        {
            imgMuteMusica.enabled = false;
        }
    }
    
    public void sonidosMute()
    {
        if (slidervalueSonidos == 0)
        {
            imgMuteSonidos.enabled = true;
        }
        else
        {
            imgMuteSonidos.enabled = false;
        }
    }

}
