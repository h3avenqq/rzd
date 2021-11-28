using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    
    public List<GameObject> cars = new List<GameObject>();

    public GameObject pref;
    public GameObject checkPlace;

    private bool check = true;
    
    private float time = 0;

    private void Start()
    {
        cars.Add(Instantiate(pref, new Vector3(-7.41f, 0f, -10f), Quaternion.identity ));
    }

    private void Update()
    {
        spawnTimer();
        
    }

    public void Spawn()
    {
        if (true)
        {
            time = 1;
            if (cars.Count<2)
            {
                cars.Add(Instantiate(pref, new Vector3(-7.41f, 0f, -10f), Quaternion.identity ));
            }
        }
    }

    public void SpawnEnd()
    {
        cars.Add(Instantiate(pref, new Vector3(-7.41f, 0f, -10f), Quaternion.identity ));

    }

    private void spawnTimer()
    {
        time -= Time.deltaTime;
    }
}
