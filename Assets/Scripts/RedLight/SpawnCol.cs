using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCol : MonoBehaviour
{
    public GameObject spawner;
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("dgf");
        spawner.GetComponent<Spawner>().Spawn();
    }
}
