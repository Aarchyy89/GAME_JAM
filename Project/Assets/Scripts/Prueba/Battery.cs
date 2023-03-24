using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Torch_FlashLight.instance.lifeTime = Torch_FlashLight.instance.lifeTime + 25;
            Destroy(gameObject);
        }
    }
  
}
