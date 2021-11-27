using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCol : MonoBehaviour
{
    public GameObject light;
    public GameObject spawner;


    public bool end = false;
    void OnCollisionEnter(Collision collision)
    { 
        if (light.GetComponent<RedLightControl>().isRed && !end)
        {
            Destroy(collision.gameObject);
            spawner.GetComponent<Spawner>().cars.RemoveAt(0);
            Time.timeScale = 0;
        }
        if (end)
        {
            Destroy(collision.gameObject);
            spawner.GetComponent<Spawner>().cars.RemoveAt(0);
            spawner.GetComponent<Spawner>().SpawnEnd();

        }
    }
}
