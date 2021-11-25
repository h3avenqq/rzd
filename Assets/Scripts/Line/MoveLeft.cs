using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float waitTimer = 1;
    public float speed = 10f;

    void Update()
    {
        waitTimer -= Time.deltaTime;
        if (waitTimer <= 0)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}