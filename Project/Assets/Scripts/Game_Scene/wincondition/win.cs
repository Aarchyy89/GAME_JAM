
using UnityEngine;

public class win : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           UI_Manager.instance.win_panel.SetActive(true); 
        }
    }
}
