
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject win_panel;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           win_panel.SetActive(true); 
        }
    }
}
