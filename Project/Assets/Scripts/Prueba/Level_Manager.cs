using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Manager : MonoBehaviour
{
    public GameObject Panel_Pause;
    public GameObject panel_muerte;
    public GameObject panel_locura;
    public GameObject Godmode;
    public CanvasGroup locura_grp;
    public GameObject player;
    public bool Pausedgame;
    public bool Godedmode;

    public float tiempo_Total;

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

        if (Input.GetKeyDown(KeyCode.G))
        {
            player.transform.position = Spawner.instance.door.gameObject.transform.position;
        }
        
        
        if(Mascota_Controller.instance.player_locura == Mascota_Controller.instance.max_locura)
        {
            ModoLocura();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo"));
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

    public void ModoLocura()
    {
        tiempo_Total -= Time.deltaTime;
        if(tiempo_Total <= 18)
        {
            locura_grp.alpha = 0.5f;
        }

        if(tiempo_Total <= 5)
        {
            locura_grp.alpha = 1;
        }

        if(tiempo_Total == 0)
        {
            Die();
        }
    }

    public void Destroy(string tag)
    {
        GameObject[] gameobjects = GameObject.FindGameObjectsWithTag(tag);
    }
}
