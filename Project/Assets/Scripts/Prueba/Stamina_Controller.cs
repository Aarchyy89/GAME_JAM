using UnityEngine;
using UnityEngine.UI;


public class Stamina_Controller : MonoBehaviour
{
    [Header("Parameters")]
    public float playerStamina = 100.0f;
    [SerializeField] private float max_stamina = 100.0f;
    [SerializeField] private float Escucha_cost;
    [HideInInspector] public bool hasRegenerated = true;
    [HideInInspector] public bool we_Are_running = false;
    [HideInInspector] public bool we_Are_Listening = false;

    [Header("Stamina_Parameters")]
    [Range(0f, 50f)][SerializeField] private float Stamina_Drain = 0.5f;
    [Range(0f, 50f)][SerializeField] private float Stamina_Regen = 0.5f;

    [Header("Stamina_Regen_Parameters")]
    [SerializeField] private int slowed_Run_Speed = 4;
    [SerializeField] private int normal_run_speed = 8;

    [Header("Stamina_UI_Elements")]
    [SerializeField] private Image stamina_Progress = null;
    [SerializeField] private CanvasGroup slider_grp = null;

    private Hola_Controller prueba_controller;

    public static Stamina_Controller instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        prueba_controller = GetComponent<Hola_Controller>();  
    }

    private void Update()
    {
        if(!we_Are_running)
        {
            if(playerStamina <= max_stamina - 0.01)
            {
                playerStamina += Stamina_Regen + Time.deltaTime;
                UpdateStamina(1);

                if(playerStamina >= max_stamina)
                {
                    slider_grp.alpha = 0;
                    hasRegenerated = true;
                }
            }
        }
    }

    public void Running()
    {
        if(hasRegenerated)
        {
            we_Are_running = true;
            playerStamina -= Stamina_Drain * Time.deltaTime;
            UpdateStamina(1);

            if(playerStamina <= 0)
            {
                hasRegenerated = false;
                //cant listen

                slider_grp.alpha = 0;
            }
        }
    }

    public void StaminaListen()
    {
        if(playerStamina >= (max_stamina * Escucha_cost / max_stamina))
        {
            playerStamina -= Escucha_cost;
            prueba_controller.PlayerListen();
            UpdateStamina(1);
        }
    }

    public void UpdateStamina(int value)
    {
        stamina_Progress.fillAmount = playerStamina / max_stamina;

        if(value == 0)
        {
            slider_grp.alpha = 0;
        }
        else
        {
            slider_grp.alpha = 1;
        }
    }

   
}
