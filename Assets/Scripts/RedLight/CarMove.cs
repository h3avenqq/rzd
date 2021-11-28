using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public static float speed = 20f;
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        speed = 0f;
    }

    private void OnMouseUp()
    {
        speed = 20f;
    }
}
