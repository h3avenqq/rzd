using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float waitTimer = 2;
    public float speed = 10f;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        waitTimer -= Time.deltaTime;
        if (waitTimer <= 0)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
