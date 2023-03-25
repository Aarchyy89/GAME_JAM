using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public GameObject Panel_Pause;
    public GameObject panel_muerte;
    public GameObject panel_locura;

    public bool Pausedgame;

    public static Level_Manager instance;

    private void Awake()
    {
        instance = this;    
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame(); 
        }
    }

    public void PauseGame()
    {
        Pausedgame = !Pausedgame;
        if (!Pausedgame)
        {
            Panel_Pause.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Panel_Pause.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Die()
    {
        panel_muerte.SetActive(true);
        //Time.timeScale = 0;
    }

    public void RestartLevel()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
