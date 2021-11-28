using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{

    public void Kill()
    {
        Destroy(this.gameObject);
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
