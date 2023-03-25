using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina_Mode : MonoBehaviour
{
    [Header("Parameters")]
      public float playerStamina = 0f;
      [SerializeField] private float max_stamina = 100.0f;
      [SerializeField] private float locura_cost;
      [HideInInspector] public bool hasRegenerated = true;
      //[HideInInspector] public bool we_Are_running = false;
      [HideInInspector] public bool we_Are_flashing = false;

      [Header("Stamina_Parameters")]
      [Range(0f, 50f)][SerializeField] private float Stamina_Drain = 0.5f;
      [Range(0f, 50f)][SerializeField] private float Stamina_Regen = 0.5f;

      //[Header("Stamina_Regen_Parameters")]
      //[SerializeField] private int slowed_Run_Speed = 4;
      //[SerializeField] private int normal_run_speed = 8;

      [Header("Stamina_UI_Elements")]
      [SerializeField] private Image stamina_Progress = null;
      [SerializeField] private CanvasGroup slider_grp = null;

      public static Stamina_Mode instance;
      private void Awake()
      {
          instance = this;
      }

      private void Start()
      {
          CharacterControllerMovement.Instance.GetComponent<CharacterControllerMovement>();
      }

      private void Update()
      {
          /**if(!we_Are_running)
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
          }*/

          if (!we_Are_flashing)
          {
              if (playerStamina <= max_stamina - 0.01)
              {
                  playerStamina += Stamina_Drain + Time.deltaTime;
                  UpdateStamina(1);

                  if (playerStamina >= max_stamina)
                  {
                      slider_grp.alpha = 1;
                      hasRegenerated = true;
                  }
              }
          }
      }

      public void Flashing()
      {
          if (hasRegenerated)
          {
              we_Are_flashing = true;
              playerStamina -= Stamina_Regen * Time.deltaTime;
              UpdateStamina(1);

              if (playerStamina <= 0)
              {
                  hasRegenerated = false;
                  Level_Manager.instance.panel_locura.gameObject.SetActive(true);

                  slider_grp.alpha = 0;
              }
          }
      }

      public void UpdateStamina(int value)
      {
          stamina_Progress.fillAmount = playerStamina / max_stamina;

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
