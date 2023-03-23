using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen_Manager : MonoBehaviour
{
    public Toggle toggle;

    public TMP_Dropdown resolution;
    Resolution[] resoluciones;
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.fullScreen) 
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;    
        }

        Resolucion();
    }

   public void PantallaCompleta(bool FS)
    {
        Screen.fullScreen = FS;
    }

    public void Resolucion()
    {
        resoluciones = Screen.resolutions; 
        resolution.ClearOptions();
        List<string> opciones = new List<string>();
        int Actualresolucion = 0;

        for(int i= 0; i < resoluciones.Length; i++) 
        {
            string opcion = resoluciones[i].width + " x " + resoluciones[i].height;
            opciones.Add(opcion);
            
            if(Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width &&
                resoluciones[i].height == Screen.currentResolution.height) 
            {
                Actualresolucion = i;
            }
        }

        resolution.AddOptions(opciones);
        resolution.value = Actualresolucion;
        resolution.RefreshShownValue();

        resolution.value = PlayerPrefs.GetInt("Resolution", 0);
    }

    public void ChangeResolution(int indiceResolucion)
    {
        PlayerPrefs.SetInt("Resolution", resolution.value);

        Resolution resolucion = resoluciones[indiceResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);  
    }
}
