using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mascota_Controller : MonoBehaviour
{
    [Header("Parameters")]
    public float player_locura = 0f;
    [SerializeField] public float max_locura = 100.0f;
    [SerializeField] private bool we_Are_flashing = false;
    
       

    [Header("Stamina_Parameters")]
    [Range(0f, 50f)][SerializeField] private float Stamina_Drain = 20f;
    [Range(0f, 50f)][SerializeField] private float Stamina_Regen = 0.5f;

    [Header("Stamina_UI_Elements")]
    [SerializeField] private Image stamina_Progress = null;
    [SerializeField] private CanvasGroup slider_grp = null;

    public static Mascota_Controller instance;

    private void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        
    }

    private void Update()
    {
        if (we_Are_flashing == false)
        {
            player_locura -= Stamina_Regen + Time.deltaTime;
            UpdateStamina(1);

           
            if (player_locura <= 0)
            {
                player_locura = 0;
                slider_grp.alpha = 0;
            }

            if(player_locura >= 1)
            {
                slider_grp.alpha = 1;
            }
        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<enemigoBasico>().StopEnemy(); 
            Flashing();
            if (player_locura == 100)
            {
                Level_Manager.instance.ModoLocura();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            we_Are_flashing = false;

            if (player_locura >= 100)
            {
                we_Are_flashing = true;
                player_locura = 100;
            }

            other.GetComponent<enemigoBasico>().GoToTarget();
            
        }
    }
    
    public void Flashing()
    {
        we_Are_flashing = true;
        player_locura += Stamina_Drain * Time.deltaTime;
        UpdateStamina(1);

        if(player_locura >= max_locura)
        {
            player_locura = 100;
        }
       
    }
    public void UpdateStamina(int value)
    {
        stamina_Progress.fillAmount = player_locura / max_locura;

        if (value == 0)
        {
            slider_grp.alpha = 0;
        }
        else
        {
            slider_grp.alpha = 1;
        }
    }
}
