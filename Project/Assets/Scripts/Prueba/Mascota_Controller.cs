using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mascota_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<enemigoBasico>().StopEnemy();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<enemigoBasico>().GoToTarget();
        }
    }
}
