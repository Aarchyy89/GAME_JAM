using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    [SerializeField] private GameObject controls_panel;
    [SerializeField] private GameObject options_panel;
    [SerializeField] private GameObject Resolution_panel;
    [SerializeField] private GameObject pantalla_panel;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Controls()
    {
        controls_panel.SetActive(true); 
    }

    public void Options()
    {
        options_panel.SetActive(true);  
    }

    public void Resolution()
    {
        Resolution_panel.SetActive(true);   
    }

    public void PantallaCompleta()
    {
        pantalla_panel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit(); 
    }

    public void ReturnMM()
    {
        controls_panel.SetActive(false);
    }    
}
