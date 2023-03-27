
using UnityEngine;

public class Magia : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Level_Manager.instance.locura_grp.alpha = 0;
            Mascota_Controller.instance.player_locura = 0;
        }
    }
}
