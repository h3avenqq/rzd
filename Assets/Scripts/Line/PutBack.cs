using UnityEngine;

public class PutBack : MonoBehaviour
{
    public void Back()
    {
        transform.position += new Vector3(30, 0, 0);
    }
}