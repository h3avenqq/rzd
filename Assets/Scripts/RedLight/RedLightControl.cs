using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class RedLightControl : MonoBehaviour
{
    public GameObject light;
   
    public Material Red;
    public Material Green;

    private float lightTimer = 3;
    public float timer;
    public float timerMax = 10;

    public Image timeBar;

    public bool isRed = false;

    private void Start()
    {
        Time.timeScale = 1;
        timer = timerMax;
        light.GetComponent<Renderer>().material = Green;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timeBar.fillAmount = timer / timerMax;
        if (timer <= 0)
        {
            Time.timeScale = 0;
            RandomLevel.Menu();
        }
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
