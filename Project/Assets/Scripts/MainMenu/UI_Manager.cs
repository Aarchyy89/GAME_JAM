using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [Header("---Paneles---")]
    public GameObject Controls_panel;
    public GameObject options_panel;
    public GameObject idioma_panel;
    public GameObject volumen_panel;
    public GameObject pause_menu;
    public GameObject win_panel;

    [Header("---Botones---")]
    public GameObject return_but;

    public static UI_Manager instance;

    private void Awake()
    {
        instance = this;
    }

    #region MainMenu

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Controls()
    {
        Controls_panel.SetActive(true);
        volumen_panel.SetActive(false);
        idioma_panel.SetActive(false); 
        options_panel.SetActive(false);
    }

    public void Options()
    {
        options_panel.SetActive(true);
        Controls_panel.SetActive(false);
        volumen_panel.SetActive(false);
        idioma_panel.SetActive(false);
    }

    public void Idioma()
    {
        idioma_panel.SetActive(true);
        Controls_panel.SetActive(false);
        volumen_panel.SetActive(false);
        options_panel.SetActive(false);
    }

    public void Volumen()
    {
        volumen_panel.SetActive(true);
        idioma_panel.SetActive(false);
        Controls_panel.SetActive(false);
        options_panel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    #endregion

    public void ReturnMainMenu()
    {
        options_panel.SetActive(false);
        Controls_panel.SetActive(false);
        volumen_panel.SetActive(false);
        idioma_panel.SetActive(false);
    }

    public void Resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1;
    }
}
