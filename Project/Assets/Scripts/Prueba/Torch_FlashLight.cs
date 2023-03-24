using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Torch_FlashLight : MonoBehaviour
{
    public Light light;
    
    public TMP_Text LIFETIME_text;
    public TMP_Text battery_text;

    public float lifeTime = 100;
    public float batteries = 0;

    public AudioSource FLASHoN;
    public AudioSource FLASHoFF;

    private bool on;
    private bool off;

    public static Torch_FlashLight instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //text.text = "Flashlight : " + lifeTime + "%";
        light = GetComponent<Light>();

        on = true;
        light.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        LIFETIME_text.text = lifeTime.ToString("0") + "%";
        battery_text.text = batteries.ToString();

        /**if(Input.GetButtonDown("flashlight") && off)
        {
            FLASHoN.Play();
            light.enabled = true;
            on = true;
        }
        else if (Input.GetButtonDown("flashlight") && on)
        {
            FLASHoFF.Play();
            light.enabled = false;
            on = false;
            off = true;
        }*/

        if(on)
        {
            lifeTime -= 5 * Time.deltaTime;
        }

        if(lifeTime <= 0) 
        {
            light.enabled = false;
            on = false;
            off = true;
            lifeTime = 0;

            //morir
        }

        if(lifeTime >= 100)
        {
            lifeTime = 100;
        }

        if(batteries <= 0)
        {
            batteries = 0;
        }
    }
}
