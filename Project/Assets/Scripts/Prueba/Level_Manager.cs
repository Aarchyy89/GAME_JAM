using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public static Level_Manager instance;

    public GameObject Panel_Pause;

    public bool Pausedgame;
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

}
