using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mascota_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        Locura_Controller.instance.GetComponent<Locura_Controller>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<enemigoBasico>().StopEnemy();
            Locura_Controller.instance.Flashing();

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
