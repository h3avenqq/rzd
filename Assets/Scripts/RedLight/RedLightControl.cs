using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class RedLightControl : MonoBehaviour
{
    public GameObject light;
   
    public Material Red;
    public Material Green;

    private float lightTimer = 3;

    public bool isRed = false;

    private void Start()
    {
        light.GetComponent<Renderer>().material = Green;
    }

    private void Update()
    {
        SwitchLight();
    }

    private void SwitchLight()
    {
        lightTimer -= Time.deltaTime;
        // Debug.Log(lightTimer);

        if (lightTimer <= 0)
        {
            Debug.Log(light.GetComponent<Renderer>().material.ToString());
            lightTimer = 4;
            if (!isRed)
            {
                light.GetComponent<Renderer>().material = Red;
                isRed = true;
            }
            else
            {
                light.GetComponent<Renderer>().material = Green;
                isRed = false;
            }
        }
    }
    
}
