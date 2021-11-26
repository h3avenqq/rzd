using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float waitTimer = 0.5f;
    public float speed = 10f;

    void Update()
    {
        waitTimer -= Time.deltaTime;
        if (waitTimer <= 0)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}